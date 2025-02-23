using Fourminator.AccountServices.Controller;
using Fourminator.AccountServices.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fourminator.AccountServices.UnitTests
{
    public class NicknameControllerTests
    {
        [Fact]
        public void GetNicknameExists_NicknameIsEmpty_ReturnsBadRequest()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("");
            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetNicknameExists_NicknameIsNull_ReturnsBadRequest()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists(null!);
            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetNicknameExists_NicknameExists_ReturnsOk()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            nicknameService.Setup(x => x.CheckNicknameExists(It.IsAny<string>())).ReturnsAsync(true);
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("test");
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetNicknameExists_NicknameDoesNotExist_ReturnsOk()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            nicknameService.Setup(x => x.CheckNicknameExists(It.IsAny<string>())).ReturnsAsync(false);
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("test");
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetNicknameExists_NicknameExists_ReturnsTrue()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            nicknameService.Setup(x => x.CheckNicknameExists(It.IsAny<string>())).ReturnsAsync(true);
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("test");
            // Assert
            Assert.True((bool)((OkObjectResult)result).Value!);
        }

        [Fact]
        public void GetNicknameExists_NicknameDoesNotExist_ReturnsFalse()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            nicknameService.Setup(x => x.CheckNicknameExists(It.IsAny<string>())).ReturnsAsync(false);
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("test");
            // Assert
            Assert.False((bool)((OkObjectResult)result).Value!);
        }

        [Fact]
        public void GetNicknameExists_NicknameExists_ThrowsDbException_ReturnsStatusCode500()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            nicknameService.Setup(x => x.CheckNicknameExists(It.IsAny<string>())).ThrowsAsync(new Exception());
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("test");
            // Assert
            Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, ((ObjectResult)result).StatusCode);
        }

        [Fact]
        public void GetNicknameExists_NicknameExists_ThrowsException_ReturnsStatusCode500()
        {
            // Arrange
            var nicknameService = new Mock<INicknameService>();
            nicknameService.Setup(x => x.CheckNicknameExists(It.IsAny<string>())).ThrowsAsync(new Exception());
            var controller = new NicknameController(nicknameService.Object);
            // Act
            var result = controller.GetNicknameExists("test");
            // Assert
            Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, ((ObjectResult)result).StatusCode);
        }

    }


}
