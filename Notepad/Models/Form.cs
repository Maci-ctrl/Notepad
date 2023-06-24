﻿using System.ComponentModel.DataAnnotations;

namespace Notepad.Models
{
    public class Form
    {
        private int _id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string  Email { get; set; }

        [Required]
        public DateOnly DateBirth { get; set; }

        public Form (string firstName, string lastName, string email, DateOnly dateBirth)
        {
            _id++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateBirth = dateBirth;
        }
    }
}
