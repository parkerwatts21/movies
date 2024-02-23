using System.ComponentModel.DataAnnotations;

namespace Mission07_Watts.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int movieID  { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a movie title")]
        public string movieTitle { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a main category")]
        public string movieCategoryOne { get; set; }
        public string? movieCategoryTwo { get; set; } = "";
        [Required(ErrorMessage = "Sorry, you need to enter in a movie year")]
        [Range(1800, 2050, ErrorMessage = "Sorry, you need to enter a number between 1800 and 2050")]
        public int movieYear { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter in a director name")]
        public string movieDirector { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter in a movie rating")]
        public string movieRating { get; set; }
        public bool? movieEdited { get; set; }
        public string? movieLent{ get; set; }

        [MaxLength(25)]
        public string? movieNotes { get; set; }
    }
}
