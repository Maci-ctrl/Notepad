using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Notepad.Data;
using Notepad.Models;
using Notepad.Services;
using NSubstitute;

namespace Notepad.Test
{
	public class NoteServisTests
	{
		private NotebookContext context = Substitute.For<NotebookContext>(); 
		private NoteService noteService;
		private Note note = new Note();
		[SetUp]
		public void Setup()
		{
		
		}

		[Test]
		public async Task Add_NoteService_NoteAdded()
		{
			//Arrange
			note.Id = 1;
			note.Title = "Test";
			note.Content = "Test";
			note.DateCreated = DateTime.Now;
			note.DateUpdated = DateTime.Now;
			//Assert
			await noteService.Add(note);
			//Act
			Assert.That(noteService.Get(note.Id) != null);
		}
	}
}