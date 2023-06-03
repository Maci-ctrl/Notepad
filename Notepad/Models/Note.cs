using System.ComponentModel.DataAnnotations;

namespace Notepad.Models
{
    public class Note
    {
        [Key]
       // [DatebaseGeneratedAtrribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public Note()
        {
            DateCreated = DateTime.Now;
        }
    }
}
