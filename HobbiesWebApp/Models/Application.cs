using System.ComponentModel.DataAnnotations;

namespace Mission07_Watts.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int movieID  { get; set; }
        public string movieTitle { get; set; }
        public string movieCategory { get; set; }
        public int movieYear { get; set; }
        public string movieDirector { get; set; }
        public string movieRating { get; set; }
        public bool movieEdited { get; set; }
        public string movieLent{ get; set; }

        [MaxLength(25)]
        public string movieNotes { get; set; }
    }
}
