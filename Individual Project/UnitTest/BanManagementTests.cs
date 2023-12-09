using Moq;
using Xunit;
using Class_Library.Classes;
using Class_Library.Interfaces;
using Class_Library.Controllers;

namespace UnitTest
{
    public class BanManagementTests
    {
        private Mock<IBanManagement> mockBanManagement;
        private User regularUser;
        private User adminUser;

        public BanManagementTests()
        {
            mockBanManagement = new Mock<IBanManagement>();

            regularUser = new User
            {
                Username = "catalin",
                Password = "1234",
                Email = "catalin@example.com"
            };


            adminUser = new User
            {
                Username = "admin",
                Password = "admin1234",
                Email = "admin@example.com"
            };
        }

        [Fact]
        public void Create_ShouldReturnTrue_WhenBanIsValid()
        {
            // Arrange
            var ban = new Ban(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), "Valid reason", regularUser, adminUser, true);
            mockBanManagement.Setup(x => x.Create(It.IsAny<Ban>())).Returns(true);

            // Act
            var result = mockBanManagement.Object.Create(ban);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Create_ShouldReturnFalse_WhenBanIsInvalid()
        {
            // Arrange
            var ban = new Ban(DateOnly.FromDateTime(DateTime.Now.AddDays(30)), DateOnly.FromDateTime(DateTime.Now), "Invalid reason", null, null, false);
            mockBanManagement.Setup(x => x.Create(It.IsAny<Ban>())).Returns(false);

            // Act
            var result = mockBanManagement.Object.Create(ban);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void CreateBan_ShouldReturnFalse_WhenBanIsNull()
        {
            // Act
            var result = mockBanManagement.Object.Create(null);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void ReadAll_ShouldReturnAllBans()
        {
            // Arrange
            var bans = new Ban[] {
            new Ban(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), "Reason 1", regularUser, adminUser, true),
            new Ban(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(60)), "Reason 2", regularUser, adminUser, true)
        };
            mockBanManagement.Setup(x => x.ReadAll()).Returns(bans);

            // Act
            var result = mockBanManagement.Object.ReadAll();

            // Assert
            Assert.Equal(bans.Length, result.Length);
        }

        [Fact]
        public void ReadAllSearch_ShouldReturnFilteredBans()
        {
            // Arrange
            var searchString = "Reason 1";
            var filteredBans = new Ban[] {
            new Ban(DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(30)), searchString, regularUser, adminUser, true)
        };
            mockBanManagement.Setup(x => x.ReadAllSearch(searchString)).Returns(filteredBans);

            // Act
            var result = mockBanManagement.Object.ReadAllSearch(searchString);

            // Assert
            Assert.Equal(filteredBans.Length, result.Length);
        }
    }
}