namespace Notepad.Models
{
    public class Form
    {
        private int _id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string  Email { get; set; }

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
