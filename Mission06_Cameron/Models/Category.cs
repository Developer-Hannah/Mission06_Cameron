﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Cameron.Models
{
    public class Category
    {
        // Set primary key for Category Class
        [Key]
        [Required]
        public int CategoryId { get; set; }

        // Set column for Category Class
        [Required]
        public string CategoryName { get; set; }
    }
}
