namespace Notepad.Services
{
    public interface INoteService
    {
        int Id { get; set; }

        string Title { get; set; }

        string Content { get; set; }

        DateTime DateCreate { get; set; }

        DateTime DateUpdaet { get; set; }

        void Get();

        void GetAll();

        void Add();

        void Delete();

        void Update();
    }
}
