using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission07_Watts.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId  { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } //Here is my Category class

        [Required(ErrorMessage = "Sorry, you need to enter a movie title")]
        public string Title { get; set; } //Required

        [Required(ErrorMessage = "Sorry, you need to enter in a movie year")]
        [Range(1888, 2050, ErrorMessage = "Sorry, you need to enter a number between 1800 and 2050")]
        public int Year { get; set; } //Required
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; } //Required

        public string? LentTo { get; set; }

        [Required]
        public int CopiedToPlex { get; set; } //Required

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
