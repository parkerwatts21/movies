﻿using System.ComponentModel.DataAnnotations;

namespace Mission07_Watts.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int movieID  { get; set; }
        [Required]
        public string movieTitle { get; set; }
        [Required]
        public string movieCategory { get; set; }
        [Required]
        public int movieYear { get; set; }
        [Required]
        public string movieDirector { get; set; }
        [Required]
        public string movieRating { get; set; }
        public bool movieEdited { get; set; }
        public string movieLent{ get; set; }

        [MaxLength(25)]
        public string movieNotes { get; set; }
    }
}
