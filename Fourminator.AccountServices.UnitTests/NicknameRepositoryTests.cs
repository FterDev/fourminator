using Fourminator.AccountServices.Persistence;
using Fourminator.Data;
using Fourminator.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Fourminator.AccountServices.UnitTests
{
    public class NicknameRepositoryTests
    {
        [Fact]
        public async Task GetNickname_GetNicknameTest_ShouldReturnNickname()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<FourminatorContext>().UseInMemoryDatabase(databaseName: "fourminator").Options;
            using var context = new FourminatorContext(options);

            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                ExternalId = "123",
                Nickname = "test",
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                ExternalId = "123",
                Nickname = "test1",
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            context.SaveChanges();

            var nicknameRepository = new NicknameRepository(context);
            var expect = "test";

            // Act
            var result = await nicknameRepository.GetNickname("test");
            // Assert
            Assert.Equal(expect, result);
        }


        [Fact]
        public async Task GetNickname_GetNonExistentNickname_ShouldReturnNull()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<FourminatorContext>().UseInMemoryDatabase(databaseName: "fourminator").Options;
            using var context = new FourminatorContext(options);

            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                ExternalId = "123",
                Nickname = "test",
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                ExternalId = "123",
                Nickname = "test1",
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });

            context.SaveChanges();

            var nicknameRepository = new NicknameRepository(context);
            string? expect = null;

            // Act
            var result = await nicknameRepository.GetNickname("notFound");
            // Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public async Task GetNickname_GetNicknameWithEmptyString_ShouldReturnNull()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<FourminatorContext>().UseInMemoryDatabase(databaseName: "fourminator").Options;
            using var context = new FourminatorContext(options);
            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                ExternalId = "123",
                Nickname = "test",
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });
            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                ExternalId = "123",
                Nickname = "test1",
                Active = true,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });
            context.SaveChanges();
            var nicknameRepository = new NicknameRepository(context);
            string? expect = null;
            // Act
            var result = await nicknameRepository.GetNickname("");
            // Assert
            Assert.Equal(expect, result);
        }

    }
}
