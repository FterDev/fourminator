using Fourminator.AccountServices.Persistence;
using Fourminator.AccountServices.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fourminator.AccountServices.UnitTests
{
    public class NicknameServiceTests
    {
        [Fact]
        public async Task CheckNicknameExists_ExistentNickname_ReturnsTrue()
        {
            var nicknameRepositoryMock = new Mock<INicknameRepository>();
            nicknameRepositoryMock.Setup(x => x.GetNickname(It.IsAny<string>())).ReturnsAsync("test");
            var nicknameRepository = nicknameRepositoryMock.Object;

            var nicknameService = new NicknameService(nicknameRepository);


            var result = await nicknameService.CheckNicknameExists("test");

            Assert.True(result);
        }

        [Fact]
        public async Task CheckNicknameExists_NonExistentNickname_ReturnsFalse()
        {
            var nicknameRepositoryMock = new Mock<INicknameRepository>();
            nicknameRepositoryMock.Setup(x => x.GetNickname(It.IsAny<string>())).ReturnsAsync((string)null!);
            var nicknameRepository = nicknameRepositoryMock.Object;
            var nicknameService = new NicknameService(nicknameRepository);

            var result = await nicknameService.CheckNicknameExists("test");
            Assert.False(result);
        }
    }
}
