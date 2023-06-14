using Microsoft.AspNetCore.Mvc;
using Moq;
using Notepad.Controllers;
using Notepad.Models;
using Notepad.Services;

namespace Notepad.Test
{
    public class NotebookControllerTests
    {
        [Test]
        public async Task Index_Returns_View_With_Notes()
        {
            // Arrange
            var expectedNotes = new List<Note>
            {
                new Note ("Note 1", "Content 1"),
                new Note ("Note 2", "Content 2")
            };

            var mockDb = new Mock<INoteService>();
            mockDb.Setup(db => db.GetAll()).ReturnsAsync(expectedNotes);

            var controller = new NotebookController(mockDb.Object);

            // Act
            var result = await controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.AreEqual(expectedNotes, result.Model);
        }


    }
}
