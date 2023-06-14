using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace Notepad.Models
{
    public class Note
    {
       

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public Note() { }

        public Note(string title, string content)
        {
            
            Title = title;
            Content = content;
            DateCreated = DateTime.Now;
            DateUpdated = DateCreated;
        }
	}
}
