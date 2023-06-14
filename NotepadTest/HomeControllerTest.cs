using Microsoft.Extensions.Logging;
using Notepad.Controllers;

namespace Notepad.Test
{
    public class HomeControllerTest
    {
        private ILogger<HomeController> logger;

        [Test]
        public void Index_Returns_ViewResult()
        {
            // Arrange
            var controller = new HomeController(logger);

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
