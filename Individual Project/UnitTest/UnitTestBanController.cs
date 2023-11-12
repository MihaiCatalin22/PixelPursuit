using Class_Library.Classes;
using Class_Library.Controllers;
using Class_Library.DAL;
using Class_Library.Interfaces;
using System.Diagnostics.Metrics;

namespace UnitTest
{
    [TestClass]
    public class UnitTestBanController
    {
        private BanController banController = new BanController(new UnitTestBanDAL());
        private UserController userController = new UserController(new UnitTestUserDAL());

        User admin = new User("catalin", "12345", "catalin@gmail.com", true);
        User user = new User("catalin2", "catalin", "testemail@gmail.com", false);

        private DateOnly startDate = new DateOnly(2023, 11, 11);
        private DateOnly endDate = new DateOnly(2024, 11, 11);
        private string reason = "Non legitimate run in submission id 4.";

        [TestMethod] //SUCCESS
        public void CreateBanTest()
        {
            //Arrange
            userController.Create(admin);
            userController.Create(user);
            admin = userController.GetUserFromUsername(admin.Username);
            user = userController.GetUserFromUsername(user.Username);
            bool result;
            //Act
            Ban ban = new(startDate, endDate, reason, user, admin);
            result = banController.Create(ban);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod] //EDGE CASE
        public void CreateNullTest()
        {
            //Arrange
            Ban ban = null;
            bool result;
            //Act
            result = banController.Create(ban);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod] //SUCCESS
        public void ReadAllTest()
        {
            //Arrange
            admin = userController.GetUserFromUsername(admin.Username);
            user = userController.GetUserFromUsername(user.Username);
            Ban ban = new(startDate, endDate, reason, user, admin);
            banController.Create(ban);
            //Act
            List<Ban> bans = banController.ReadAll().ToList();
            //Assert
            Assert.AreNotEqual(0, bans.Count);
        }

        [TestMethod] //SUCCESS
        public void ReadAllSearchTest()
        {
            //Arrange
            admin = userController.GetUserFromUsername(admin.Username);
            user = userController.GetUserFromUsername(user.Username);          
            Ban ban = new(startDate, endDate, reason, user, admin);
            banController.Create(ban);
            //Act
            List<Ban> bans = banController.ReadAllSearch(user.Username).ToList();
            //Assert
            Assert.AreNotEqual(0, bans.Count);
        }
    }
}