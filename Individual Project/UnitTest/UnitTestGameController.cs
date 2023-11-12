using Class_Library.Classes;
using Class_Library.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTestGameController
    {
        private GameController gameController = new(new UnitTestGameDAL());

        private string name = "Re-Volt";
        private string company = "Acclaim Studios London";
        private DateOnly date = new DateOnly(1999, 9, 3);
        private string genres = $"{EnumGenre.Racing.ToString()}";
        private string platforms = $"{EnumPlatform.Android}, {EnumPlatform.iOS},{EnumPlatform.N64}, {EnumPlatform.Playstation}, {EnumPlatform.PC}";
        private string trailer = "https://www.youtube.com/watch?v=aTsFnNZKFZg";
        private string picture = "https://upload.wikimedia.org/wikipedia/en/5/5b/Re-Volt_Coverart.jpg";
        private string background = "https://re-volt.io/user/pages/home/home/race.jpg";

        [TestMethod] //SUCCESS
        public void CreateTest()
        {
            //Arrange
            bool result;
            //Act
            Game game = new(name, company, date, genres, platforms, trailer, picture, background); ;
            result = gameController.Create(game);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod] //EDGE CASE
        public void CreateNullTest()
        {
            //Arrange
            Game game = null;
            bool result;
            //Act
            result = gameController.Create(game);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //SUCCESS
        public void ReadByIdTest()
        {
            //Arrange            
            //Act
            Game game = gameController.ReadByID(1);
            //Assert
            Assert.AreEqual(1, game.ID);
        }

        [TestMethod] //EDGE CASE
        public void ReadByIdNonExistentTest()
        {
            //Arrange            
            //Act
            Game game = gameController.ReadByID(0);
            //Assert
            Assert.AreEqual(null, game);
        }

        [TestMethod] //SUCCESS
        public void ReadAllTest()
        {
            //Arrange            
            //Act
            List<Game> games = gameController.ReadAll().ToList();
            //Assert
            Assert.AreNotEqual(0, games.Count);
        }

        [TestMethod] //SUCCESS
        public void ReadOnePageByNameTest()
        {
            //Arrange
            Game game = gameController.ReadByID(1);
            //Act
            List<Game> games = gameController.ReadOnePageByName(0, game.Name).ToList();
            //Assert
            Assert.AreEqual(game.ID, games[0].ID);
        }

        [TestMethod] //SUCCESS
        public void ReadAllByNameTest()
        {
            //Arrange
            Game game = gameController.ReadByID(1);
            //Act
            List<Game> games = gameController.ReadAllByName(game.Name).ToList();
            //Assert
            Assert.AreEqual(game.ID, games[0].ID);
        }

        [TestMethod] //SUCCESS
        public void ReadAllSearchTest()
        {
            //Arrange
            Game game = gameController.ReadByID(1);
            //Act
            List<Game> games = gameController.ReadAllSearch(game.Name, game.Company).ToList();
            //Assert
            Assert.AreEqual(game.ID, games[0].ID);
        }

        [TestMethod] //SUCCESS
        public void UpdateTest()
        {
            //Arrange
            Game game = gameController.ReadByID(1);
            //Act
            game.Name = "Test";
            bool result = gameController.Update(game);
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod] //EDGE CASE
        public void UpdateNothingTest()
        {
            //Arrange
            Game game = gameController.ReadByID(0);
            //Act
            bool result = gameController.Update(game);
            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod] //SUCCESS
        public void DeleteTest()
        {
            //Arrange
            Game game = gameController.ReadByID(1);
            //Act
            bool result = gameController.Delete(game);
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod] //EDGE CASES
        public void DeleteNothingTest()
        {
            //Arrange
            Game game = gameController.ReadByID(0);
            //Act
            bool result = gameController.Delete(game);
            //Assert
            Assert.AreEqual(result, false);
        }

        [TestMethod] //SUCCESS
        public void GetTotalPagesTest()
        {
            //Arrange
            int pagesize = 4;
            //Act
            int page = gameController.GetTotalPages(pagesize);
            //Assert
            Assert.AreEqual(page, 0);
        }

    }
}

