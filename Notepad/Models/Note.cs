using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace Notepad.Models
{
    public class Note
    {
       

        [Key]
        // [DatebaseGeneratedAtrribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
	}
}
