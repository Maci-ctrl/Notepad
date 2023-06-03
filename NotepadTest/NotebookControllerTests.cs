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

        private NoteService _noteService = Substitute.For<NoteService>();


        [Test]
        public async Task TestIndexViewData()
        {
            // Arrange + Act
            var controller = new NotebookController(_noteService);

            var result = await controller.Index() as ViewResult;
            
            
            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }

    }
}
