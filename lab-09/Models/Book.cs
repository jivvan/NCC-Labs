using System.ComponentModel.DataAnnotations;

namespace models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The title is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The title must be between 1 and 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The author is required.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The author's name must be between 5 and 50 characters.")]
        public string Author { get; set; }

        [StringLength(30, MinimumLength = 3, ErrorMessage = "The genre must be less than 30 characters.")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "The ISBN is required.")]
        [RegularExpression(@"\d{13}", ErrorMessage = "The ISBN must be a 13-digit number.")]
        public string ISBN { get; set; }
    }
}
