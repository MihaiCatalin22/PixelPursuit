using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Class_Library.Controllers;
using Class_Library.Interfaces;
using Class_Library.Classes;

namespace UnitTest
{
    public class UserManagementTests
    {
        private Mock<IUserManagement> mockUserManagement;
        private UserController userController;

        public UserManagementTests()
        {
            mockUserManagement = new Mock<IUserManagement>();
            userController = new UserController(mockUserManagement.Object);
        }

        [Fact]
        public void Create_ShouldReturnTrue_WhenUserIsNew()
        {
            // Arrange
            var newUser = new User { Username = "newUser",};
            mockUserManagement.Setup(um => um.ReadAll()).Returns(new User[] { });
            mockUserManagement.Setup(um => um.Create(It.IsAny<User>())).Returns(true);

            // Act
            var result = userController.Create(newUser);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Create_ShouldReturnFalse_WhenUsernameExists()
        {
            // Arrange
            var existingUser = new User { Username = "existingUser",};
            mockUserManagement.Setup(um => um.ReadAll()).Returns(new User[] { existingUser });

            // Act
            var result = userController.Create(new User { Username = "existingUser",});

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void Create_ShouldReturnFalse_WhenUserIsNull()
        {
            // Act
            var result = userController.Create(null);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void Create_ShouldReturnFalse_WhenUserDataIsInvalid()
        {
            // Arrange
            var invalidUser = new User { Username = "", Email = "invalidEmail"};

            // Act
            var result = userController.Create(invalidUser);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void Update_ShouldReturnTrue_WhenUserExists()
        {
            // Arrange
            var existingUser = new User { Id = 1};
            mockUserManagement.Setup(um => um.GetUserFromId(existingUser.Id)).Returns(existingUser);
            mockUserManagement.Setup(um => um.Update(It.IsAny<User>())).Returns(true);

            // Act
            var result = userController.Update(existingUser);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Update_ShouldReturnFalse_WhenUserDoesNotExist()
        {
            // Arrange
            mockUserManagement.Setup(um => um.GetUserFromId(It.IsAny<int>())).Returns((User)null);

            // Act
            var result = userController.Update(new User { Id = 99 }) ;

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void Delete_ShouldReturnTrue_WhenUserExists()
        {
            // Arrange
            var userToDelete = new User { Id = 1};
            mockUserManagement.Setup(um => um.GetUserFromId(userToDelete.Id)).Returns(userToDelete);
            mockUserManagement.Setup(um => um.Delete(It.IsAny<User>())).Returns(true);

            // Act
            var result = userController.Delete(userToDelete);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Delete_ShouldReturnFalse_WhenUserDoesNotExist()
        {
            // Arrange
            mockUserManagement.Setup(um => um.GetUserFromId(It.IsAny<int>())).Returns((User)null);

            // Act
            var result = userController.Delete(new User { Id = 99});

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void ReadAll_ShouldReturnUsers()
        {
            // Arrange
            var users = new User[] { new User { Id = 1 }, new User { Id = 2 } };
            mockUserManagement.Setup(um => um.ReadAll()).Returns(users);

            // Act
            var result = userController.ReadAll();

            // Assert
            Assert.Equal(2, result.Length);
        }
        [Fact]
        public void ReadAllUsers_ShouldReturnAllNonAdminUsers()
        {
            // Arrange
            var users = new User[]
            {
                new User { Id = 1, IsAdmin = false },
                new User { Id = 2, IsAdmin = false }
            };
            mockUserManagement.Setup(um => um.ReadAllUsers()).Returns(users);

            // Act
            var result = userController.ReadAllUsers();

            // Assert
            Assert.Equal(users.Length, result.Length);
        }
        [Fact]
        public void ReadAllAdmins_ShouldReturnAllAdminUsers()
        {
            // Arrange
            var admins = new User[]
            {
                new User { Id = 1, IsAdmin = true },
                new User { Id = 2, IsAdmin = true }
            };
            mockUserManagement.Setup(um => um.ReadAllAdmins()).Returns(admins);

            // Act
            var result = userController.ReadAllAdmins();

            // Assert
            Assert.Equal(admins.Length, result.Length);
        }
        [Fact]
        public void ReadAllUsersSearch_ShouldReturnFilteredUsers()
        {
            // Arrange
            var users = new User[]
            {
                new User { Id = 1, Username = "JohnDoe" },
                new User { Id = 2, Username = "JaneDoe" }
            };
            string searchQuery = "John";
            mockUserManagement.Setup(um => um.ReadAllUsersSearch(searchQuery)).Returns(users.Where(u => u.Username.Contains(searchQuery)).ToArray());

            // Act
            var result = userController.ReadAllUsersSearch(searchQuery);

            // Assert
            Assert.Single(result);
            Assert.Contains(result, u => u.Username.Contains(searchQuery));
        }
        [Fact]
        public void GetUserFromUsername_ShouldReturnUser_WhenUsernameExists()
        {
            // Arrange
            var user = new User { Id = 1, Username = "JohnDoe" };
            mockUserManagement.Setup(um => um.GetUserFromUsername(user.Username)).Returns(user);

            // Act
            var result = userController.GetUserFromUsername(user.Username);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user.Username, result.Username);
        }

        [Fact]
        public void GetUserFromUsername_ShouldReturnNull_WhenUsernameDoesNotExist()
        {
            // Arrange
            string nonExistingUsername = "NonExistentUser";
            mockUserManagement.Setup(um => um.GetUserFromUsername(nonExistingUsername)).Returns((User)null);

            // Act
            var result = userController.GetUserFromUsername(nonExistingUsername);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void GetUserFromId_ShouldReturnUser_WhenUserIdExists()
        {
            // Arrange
            var user = new User { Id = 1 };
            mockUserManagement.Setup(um => um.GetUserFromId(user.Id)).Returns(user);

            // Act
            var result = userController.GetUserFromId(user.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user.Id, result.Id);
        }

        [Fact]
        public void GetUserFromId_ShouldReturnNull_WhenUserIdDoesNotExist()
        {
            // Arrange
            int nonExistingUserId = 99;
            mockUserManagement.Setup(um => um.GetUserFromId(nonExistingUserId)).Returns((User)null);

            // Act
            var result = userController.GetUserFromId(nonExistingUserId);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void GetSalt_ShouldReturnSalt_WhenUserExists()
        {
            // Arrange
            var user = new User { Id = 1 };
            string expectedSalt = "someSalt";
            mockUserManagement.Setup(um => um.GetUserFromId(user.Id)).Returns(user);
            mockUserManagement.Setup(um => um.GetSalt(user)).Returns(expectedSalt);

            // Act
            var result = userController.GetSalt(user);

            // Assert
            Assert.Equal(expectedSalt, result);
        }

        [Fact]
        public void GetSalt_ShouldReturnNull_WhenUserDoesNotExist()
        {
            // Arrange
            var nonExistingUser = new User { Id = 99 };
            mockUserManagement.Setup(um => um.GetUserFromId(nonExistingUser.Id)).Returns((User)null);

            // Act
            var result = userController.GetSalt(nonExistingUser);

            // Assert
            Assert.Null(result);
        }
    }
}
