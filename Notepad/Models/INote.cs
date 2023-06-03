namespace Notepad.Models
{
    public interface Interface
    {
        int Id { get; set; }

        string Name { get; set; }

        string Content { get; set; }

        DateTime DateCreate { get; set; }

        DateTime DateUpdaet { get; set; }

        void Edit();

        void Delete();

        void Update();
    }
}
