using System.ComponentModel.DataAnnotations;

namespace CarQuest.Models
{
    public class CarInventory
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Make is required.")]
        [StringLength(30, ErrorMessage = "Make must be 30 characters or less.")]
        public string? Make { get; set; }

        [Required(ErrorMessage = "Model is required.")]
        [StringLength(30, ErrorMessage = "Model must be 30 characters or less.")]
        public string? Model { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100.")]
        public int Year { get; set; }

        // Foreign Key
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
    }
}
