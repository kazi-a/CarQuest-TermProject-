using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarQuest.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Please enter your full name using 30 characters or less.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Please enter your full name using 30 characters or less.")]
        public string? LastName { get; set; }

        [Display(Name = "Gender")]
        public Gender? GenderIdentity { get; set; }

        [StringLength(50, ErrorMessage = "Please enter your address using 50 characters or less.")]
        public string? Address { get; set; }

        [StringLength(30, ErrorMessage = "Please enter the city using 30 characters or less.")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Please enter the state using 2 characters.")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Zipcode has a maximum length of 10 numbers.")]
        public string? Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        [Column("Customer_Email")]
        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Cell phone must be 10 digits.")]
        public string? Cell { get; set; }

        public ICollection<CarInventory> CarInventories { get; set; } = new List<CarInventory>();
    }
}
