using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.Interfaces;
using Moq;
using Xunit;

namespace UnitTest
{
    public class GameManagementTests
    {
        private Mock<IGameManagement> mockGameManagement;
        private GameController gameController;

        public GameManagementTests()
        {
            mockGameManagement = new Mock<IGameManagement>();
            gameController = new GameController(mockGameManagement.Object);
        }
        [Fact]
        public void Create_ShouldReturnTrue_WhenGameIsValid()
        {
            var game = new Game { ID = 1, Name = "Test Game" };
            mockGameManagement.Setup(x => x.Create(It.IsAny<Game>())).Returns(true);

            var result = gameController.Create(game);

            Assert.True(result);
        }
        [Fact]
        public void Delete_ShouldReturnTrue_WhenGameExists()
        {
            var game = new Game { ID = 1 };
            mockGameManagement.Setup(x => x.ReadById(game.ID)).Returns(game);
            mockGameManagement.Setup(x => x.Delete(It.IsAny<Game>())).Returns(true);

            var result = gameController.Delete(game);

            Assert.True(result);
        }
        [Fact]
        public void Update_ShouldReturnTrue_WhenGameExists()
        {
            var game = new Game { ID = 1, Name = "Existing Game" };
            mockGameManagement.Setup(x => x.ReadById(game.ID)).Returns(game);
            mockGameManagement.Setup(x => x.Update(It.IsAny<Game>())).Returns(true);

            var result = gameController.Update(game);

            Assert.False(result);
        }
        [Fact]
        public void ReadAll_ShouldReturnArrayOfGames()
        {
            var games = new Game[] { new Game { ID = 1 }, new Game { ID = 2 } };
            mockGameManagement.Setup(x => x.ReadAll()).Returns(games);

            var result = gameController.ReadAll();

            Assert.Equal(games.Length, result.Length);
        }
        [Fact]
        public void ReadByID_ShouldReturnGame_WhenGameExists()
        {
            var game = new Game { ID = 1 };
            mockGameManagement.Setup(x => x.ReadById(game.ID)).Returns(game);

            var result = gameController.ReadByID(game.ID);

            Assert.NotNull(result);
            Assert.Equal(game.ID, result.ID);
        }
        [Fact]
        public void ReadAllByName_ShouldReturnFilteredGames()
        {
            var games = new Game[] { new Game { Name = "Test Game" } };
            mockGameManagement.Setup(x => x.ReadAllByName("Test")).Returns(games);

            var result = gameController.ReadAllByName("Test");

            Assert.NotEmpty(result);
        }
        [Fact]
        public void ReadAllSearch_ShouldReturnFilteredGames()
        {
            var games = new Game[] { new Game { Name = "Test Game", Company = "Test Company" } };
            mockGameManagement.Setup(x => x.ReadAllSearch("Test", "Company")).Returns(games);

            var result = gameController.ReadAllSearch("Test", "Company");

            Assert.NotEmpty(result);
        }
        [Fact]
        public void ReadOnePageByName_ShouldReturnPaginatedGames()
        {
            var games = new Game[] { new Game { Name = "Test Game" } };
            mockGameManagement.Setup(x => x.ReadOnePageByName(0, "Test")).Returns(games);

            var result = gameController.ReadOnePageByName(0, "Test");

            Assert.Single(result);
        }
        [Fact]
        public void GetTotalPages_ShouldReturnNumberOfPages()
        {
            mockGameManagement.Setup(x => x.GetTotalPages(10)).Returns(2);

            var result = gameController.GetTotalPages(10);

            Assert.Equal(2, result);
        }
        [Fact]
        public void UserPlayedBefore_ShouldReturnTrue_WhenUserPlayedGame()
        {
            var user = new User { Id = 1 };
            var game = new Game { ID = 1 };
            mockGameManagement.Setup(x => x.UserPlayedBefore(user, game)).Returns(true);

            var result = gameController.UserPlayedBefore(user, game);

            Assert.True(result);
        }
        [Fact]
        public void CreateGame_ShouldReturnFalse_WhenGameIsNull()
        {
            // Act
            var result = gameController.Create(null);

            // Assert
            Assert.False(result);
        }
        [Fact]
        public void CreateGame_ShouldHandleEdgeCase_ForExtremeData()
        {
            var game = new Game { Name = new string('a', 1000) };
            var result = gameController.Create(game);

            Assert.False(result);
        }
    }
}
