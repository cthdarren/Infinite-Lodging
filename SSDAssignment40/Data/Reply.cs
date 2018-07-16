﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSDAssignment40.Data
{
    public class Reply
    {
        [Key]
        public int reply_ID { get; set; }

        public int CustomerSupport_ID { get; set; }

        [Display(Name = "Replies")]
        public string Replies { get; set; }
    }
}
