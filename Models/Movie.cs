﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
	public class Movie
	{
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
		[DisplayName("Release Date")]
		[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string? Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
