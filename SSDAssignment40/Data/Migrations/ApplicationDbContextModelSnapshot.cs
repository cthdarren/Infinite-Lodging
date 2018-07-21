﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSDAssignment40.Data;

namespace SSDAssignment40.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SSDAssignment40.Data.AuditRecord", b =>
                {
                    b.Property<int>("Audit_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuditActionType");

                    b.Property<DateTime>("DateTimeStamp");

                    b.Property<string>("LodgerId");

                    b.Property<string>("Username");

                    b.HasKey("Audit_ID");

                    b.HasIndex("LodgerId");

                    b.ToTable("AuditRecords");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Booking", b =>
                {
                    b.Property<string>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEnd");

                    b.Property<DateTime>("DateStart");

                    b.Property<string>("ListingId");

                    b.Property<string>("LodgerId");

                    b.HasKey("BookingId");

                    b.HasIndex("ListingId");

                    b.HasIndex("LodgerId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("SSDAssignment40.Data.CreditCard", b =>
                {
                    b.Property<string>("CreditCardId");

                    b.Property<int>("CVV");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<string>("FullName");

                    b.Property<string>("LodgerId");

                    b.HasKey("CreditCardId");

                    b.HasIndex("LodgerId");

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("SSDAssignment40.Data.CustomerSupport", b =>
                {
                    b.Property<int>("CustomerSupport_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeStamp");

                    b.Property<string>("LodgerId");

                    b.Property<int>("NoReplies");

                    b.Property<string>("Request");

                    b.Property<string>("Username");

                    b.HasKey("CustomerSupport_ID");

                    b.HasIndex("LodgerId");

                    b.ToTable("CustomerSupport");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Listing", b =>
                {
                    b.Property<string>("ListingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoverPic");

                    b.Property<string>("Desc");

                    b.Property<string>("Location");

                    b.Property<string>("LodgerId");

                    b.Property<int>("Price");

                    b.Property<string>("Title");

                    b.HasKey("ListingId");

                    b.HasIndex("LodgerId");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Lodger", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AdditionalVerificationSecret");

                    b.Property<string>("Address");

                    b.Property<string>("AlternateEmail");

                    b.Property<string>("Biography");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateJoined");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<string>("Gender");

                    b.Property<string>("GovernmentID");

                    b.Property<string>("Hobbies");

                    b.Property<string>("IPAddress");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Nric");

                    b.Property<string>("Occupation");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePic");

                    b.Property<int>("Rating");

                    b.Property<bool>("RequireAdditionalVerification");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("SiteLabel");

                    b.Property<string>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("is3AuthEnabled");

                    b.Property<string>("is3AuthPattern");

                    b.Property<bool>("isVerified");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Reply", b =>
                {
                    b.Property<int>("reply_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerSupport_ID");

                    b.Property<string>("Replies");

                    b.HasKey("reply_ID");

                    b.ToTable("Reply");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Review", b =>
                {
                    b.Property<string>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("ListingId");

                    b.Property<string>("LodgerId");

                    b.Property<int>("Rating");

                    b.Property<string>("ReviewDesc");

                    b.Property<string>("ReviewTitle");

                    b.HasKey("ReviewId");

                    b.HasIndex("ListingId");

                    b.HasIndex("LodgerId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("SSDAssignment40.Data.UserRating", b =>
                {
                    b.Property<string>("UserRatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RatedId");

                    b.Property<string>("RaterId");

                    b.HasKey("UserRatingId");

                    b.HasIndex("RatedId");

                    b.HasIndex("RaterId");

                    b.ToTable("UserRating");
                });

            modelBuilder.Entity("SSDAssignment40.Data.UserReport", b =>
                {
                    b.Property<string>("UserReportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ReportFileEvidence");

                    b.Property<string>("ReportedContent");

                    b.Property<string>("ReportedUserId");

                    b.Property<string>("ReportingUserId");

                    b.Property<DateTime>("TimeStamp");

                    b.Property<bool>("isReviewd");

                    b.HasKey("UserReportId");

                    b.HasIndex("ReportedUserId");

                    b.HasIndex("ReportingUserId");

                    b.ToTable("UserReport");
                });

            modelBuilder.Entity("SSDAssignment40.Data.UserReview", b =>
                {
                    b.Property<string>("UserReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ReviewById");

                    b.Property<string>("ReviewContent");

                    b.Property<string>("ReviewForId");

                    b.Property<DateTime>("ReviewTimeStamp");

                    b.HasKey("UserReviewId");

                    b.HasIndex("ReviewById");

                    b.HasIndex("ReviewForId");

                    b.ToTable("UserReview");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SSDAssignment40.Data.Lodger")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SSDAssignment40.Data.AuditRecord", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "Lodger")
                        .WithMany()
                        .HasForeignKey("LodgerId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Booking", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Listing", "Listing")
                        .WithMany()
                        .HasForeignKey("ListingId");

                    b.HasOne("SSDAssignment40.Data.Lodger", "Lodger")
                        .WithMany()
                        .HasForeignKey("LodgerId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.CreditCard", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "Lodger")
                        .WithMany()
                        .HasForeignKey("LodgerId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.CustomerSupport", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "Lodger")
                        .WithMany()
                        .HasForeignKey("LodgerId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Listing", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "Lodger")
                        .WithMany()
                        .HasForeignKey("LodgerId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.Review", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Listing", "Listing")
                        .WithMany()
                        .HasForeignKey("ListingId");

                    b.HasOne("SSDAssignment40.Data.Lodger", "Lodger")
                        .WithMany()
                        .HasForeignKey("LodgerId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.UserRating", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "Rated")
                        .WithMany()
                        .HasForeignKey("RatedId");

                    b.HasOne("SSDAssignment40.Data.Lodger", "Rater")
                        .WithMany()
                        .HasForeignKey("RaterId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.UserReport", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "ReportedUser")
                        .WithMany()
                        .HasForeignKey("ReportedUserId");

                    b.HasOne("SSDAssignment40.Data.Lodger", "ReportingUser")
                        .WithMany()
                        .HasForeignKey("ReportingUserId");
                });

            modelBuilder.Entity("SSDAssignment40.Data.UserReview", b =>
                {
                    b.HasOne("SSDAssignment40.Data.Lodger", "ReviewBy")
                        .WithMany()
                        .HasForeignKey("ReviewById");

                    b.HasOne("SSDAssignment40.Data.Lodger", "ReviewFor")
                        .WithMany()
                        .HasForeignKey("ReviewForId");
                });
#pragma warning restore 612, 618
        }
    }
}
