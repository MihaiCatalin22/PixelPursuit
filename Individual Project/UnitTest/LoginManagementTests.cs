using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Class_Library.Controllers;
using Class_Library.Interfaces;

namespace UnitTest
{
    public class LoginManagementTests
    {
        private LoginController loginController;

        public LoginManagementTests()
        {
            loginController = new LoginController();
        }

        [Fact]
        public void LoginUsername_ShouldReturnUser_WhenCredentialsAreValid()
        {
            // Arrange
            string validUsername = "catalin2";
            string validPassword = "Catalin";

            // Act
            var result = loginController.LoginUsername(validUsername, validPassword);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(validUsername, result.Username);
        }
        [Fact]
        public void LoginUsername_ShouldReturnNull_WhenCredentialsAreInvalid()
        {
            // Arrange
            string invalidUsername = "nonExistingUsername";
            string invalidPassword = "wrongPassword";

            // Act
            var result = loginController.LoginUsername(invalidUsername, invalidPassword);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void LoginEmail_ShouldReturnNull_WhenCredentialsAreInvalid()
        {
            // Arrange
            string invalidEmail = "nonExistingEmail@example.com";
            string invalidPassword = "wrongPassword";

            // Act
            var result = loginController.LoginEmail(invalidEmail, invalidPassword);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void LoginUsernameAdmin_ShouldReturnAdmin_WhenCredentialsAreValid()
        {
            // Arrange
            string validUsername = "catalin";
            string validPassword = "12345";

            // Act
            var result = loginController.LoginUsernameAdmin(validUsername, validPassword);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsAdmin);
        }
        [Fact]
        public void LoginUsernameAdmin_ShouldReturnNull_WhenCredentialsAreInvalid()
        {
            // Arrange
            string invalidUsername = "nonExistingAdminUsername";
            string invalidPassword = "wrongPassword";

            // Act
            var result = loginController.LoginUsernameAdmin(invalidUsername, invalidPassword);

            // Assert
            Assert.Null(result);
        }
        [Fact]
        public void LoginUsername_ShouldReturnNull_WhenCredentialsAreEmptyOrNull()
        {
            // Act
            var result = loginController.LoginUsername("", "");

            // Assert
            Assert.Null(result);
        }
    }
}
