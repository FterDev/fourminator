using Fourminator.AccountServices.Persistence;
using Fourminator.AccountServices.Services;
using Fourminator.Data.Exceptions;
using Moq;
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

        [Fact]
        public async Task CheckNicknameExists_RepositoryThrowsException_ThrowsDbException()
        {
            var nicknameRepositoryMock = new Mock<INicknameRepository>();
            nicknameRepositoryMock.Setup(x => x.GetNickname(It.IsAny<string>())).ThrowsAsync(new Exception());
            var nicknameRepository = nicknameRepositoryMock.Object;
            var nicknameService = new NicknameService(nicknameRepository);
            await Assert.ThrowsAsync<DbException>(() => nicknameService.CheckNicknameExists("test"));
        }
    }
}
