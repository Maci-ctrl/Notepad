using Microsoft.AspNetCore.Mvc;
using Notepad.Controllers;
using Notepad.Models;
using Notepad.Services;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Test
{
    public class NotebookControllerTests
    {

        private INoteService _noteService = Substitute.For<INoteService>();


        [Test]
        //[AutoData]
        public async Task TestIndexViewData()
        {
            // Arrange
            var controller = new NotebookController(_noteService);

            // auto list
			var notes = new Note[]
		   {
				new Note {Id = 1, Title = "Note 1 Title", Content = "Note 1 Content", DateCreated= new DateTime(2023,05,30,09,30,00), DateUpdated = new DateTime(2023,05,30,09,45,00)},
				new Note {Id = 2, Title = "Note 2 Title", Content = "Note 2 Content", DateCreated= new DateTime(2023,05,31,09,30,00), DateUpdated = new DateTime(2023,05,31,09,45,00)},
				new Note {Id = 3, Title = "Note 3 Title", Content = "Note 3 Content", DateCreated= new DateTime(2023,06,1,09,30,00), DateUpdated = new DateTime(2023,06,1,09,45,00)},
				new Note {Id = 4, Title = "Note 4 Title", Content = "Note 4 Content", DateCreated= new DateTime(2023,06,2,09,30,00), DateUpdated = new DateTime(2023,06,2,09,45,00)},
		   };


			_noteService.GetAll().Returns(notes);

            // Act
            var result = await controller.Index() as ViewResult;


            // Assert
            Assert.AreEqual(result.Model, notes);
        }

    }
}
