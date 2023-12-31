﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApp_RazorPages_Architeture.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public required string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Range should be between 1 and 100.")]
        public int DisplayOrder { get; set; }
    }
}
