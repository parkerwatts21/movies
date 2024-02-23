using System.ComponentModel.DataAnnotations;

namespace Mission07_Watts.Models
{
    public class Category
    {
        [Key]

        [Required]
        public int CategoryId { get; set; } //Category Id
        
        [Required]
        public string CategoryName { get; set; } //Name of the Category and Required
    }
}
