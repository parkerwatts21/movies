using System.ComponentModel.DataAnnotations;

namespace Mission07_Watts.Models
{
    public class Application
    {
        public int movieID  { get; set; }
        public required string movieTitle { get; set; }
        public required string movieCategory { get; set; }
        public required int movieYear { get; set; }
        public required string movieDirector { get; set; }
        public required string movieRating { get; set; }
        public bool movieEdited { get; set; }
        public string movieLent{ get; set; }

        [MaxLength(25)]
        public string movieNotes { get; set; }
    }
}
