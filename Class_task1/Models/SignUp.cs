using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Class_task1.Models
{
    public class SignUp : AgeValidator
    {
        [Required(ErrorMessage = "Name is required")]
        
        [RegularExpression(@"^[A-Za-z\s\.,\-]+$", ErrorMessage = "Name must only contain letters, spaces, dots, commas, and dashes.")]        public string Name { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^[0-9A-Za-z_-]{4,12}$", ErrorMessage = "Username must be between 4 and 12 characters and can only contain numbers, letters, hyphens, and underscores.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Id is required")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "Id must follow the format 'xx-xxxxx-x' where 'x' is an integer number.")]
        public string Id { get; set; }




        [Required(ErrorMessage = "Date of Birth is required")]
        [AgeValidator(ErrorMessage = "Age must be 18 or older.")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Za-z].*[A-Za-z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least 2 alphabetic characters, 1 number, and 2 special characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[0-9]{2}-\d{5}-[0-9]@student\.aiub\.edu$", ErrorMessage = "Email must follow the format 'xx-xxxxx-x@student.aiub.edu' where 'x' is a Number.")]
        public string Email { get; set; }


    }
}