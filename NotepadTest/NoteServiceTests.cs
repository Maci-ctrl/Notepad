using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Notepad.Data;
using Notepad.Models;
using Notepad.Services;
using NSubstitute;

namespace Notepad.Test
{
	public class NoteServiceTests
	{
        [Test]
        public async Task Add_Should_Add_Note_To_Context_And_SaveChanges()
        {
            // Arrange
            var context = Substitute.For<NotebookContext>();
            var service = new NoteService(context);

            string title = "New Title";
            string content = "New Content";

            // Act
            await service.Add(title, content);

            // Assert
            await context.Notes.Received(1).AddAsync(Arg.Is<Note>(n => n.Title == title && n.Content == content));
            await context.Received(1).SaveChangesAsync();
        }



    }
}