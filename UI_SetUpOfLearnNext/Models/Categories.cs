﻿using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models.Udemy.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string? CategoriesName { get; set; }
    }
}
