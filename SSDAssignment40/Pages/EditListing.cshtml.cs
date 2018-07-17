﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SSDAssignment40.Data;

namespace SSDAssignment40.Pages
{
    public class EditListingModel : PageModel
    {
        private readonly SSDAssignment40.Data.ApplicationDbContext _context;

        public EditListingModel(SSDAssignment40.Data.ApplicationDbContext context, IHostingEnvironment environment, UserManager<Lodger> user)
        {
            _context = context;
            _environment = environment;
            userManager = user;
        }

        [BindProperty]
        public Listing Listing { get; set; }

        [BindProperty]
        public IFormFile Upload { get; set; }

        private IHostingEnvironment _environment;

        public string hex { get; set; }

        List<string> allowedFileTypes = new List<string>() { "FFD8", "8950" };

        public UserManager<Lodger> userManager { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Listing = await _context.Listing.FirstOrDefaultAsync(m => m.ListingId == id);

            if (Listing == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var filename = Guid.NewGuid().ToString() + Path.GetExtension(Upload.FileName);
            var file = Path.Combine(_environment.ContentRootPath, "wwwroot", "ListingCover", filename);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
                using (var ms = new MemoryStream())
                {
                    Upload.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    hex = BitConverter.ToString(fileBytes).Replace("-", "").Substring(0, 4);

                    if (!allowedFileTypes.Contains(hex))
                    {
                        return RedirectToPage("/Error/wrongFileType");
                    }
                    Listing.CoverPic = filename;
                }
            }

            _context.Attach(Listing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListingExists(Listing.ListingId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Listings");
        }

        private bool ListingExists(string id)
        {
            return _context.Listing.Any(e => e.ListingId == id);
        }

        public async Task<IActionResult> OnPostDeleteListingAsync()
        {
            try
            {
                if (Listing != null)
                {
                    _context.Listing.Remove(Listing);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (ex is SqlException || ex is DbUpdateException)
                    return RedirectToPage("./Error/deletelistingerror");
            }
            return RedirectToPage("./Listings");
        }
    }
}
