﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Models
{
    public class LibraryBranch
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public String Name { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public string Telephone { get; set; }
        public string Description { get; set; }
        public DateTime OpentDate { get; set; }

        public virtual IEnumerable<Patron> Patrons {get; set;}
        public virtual IEnumerable<LibraryAsset> LibraryAssets { get; set; }

        public string ImageUrl { get; set; }


    }
}