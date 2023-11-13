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

        User user = new User("cata", "password123", "catalin@gmail.com", false);
        User admin = new User("admin", "adminpass", "admin@gmail.com", true);

        private DateOnly startDate = new DateOnly(2023, 11, 13);
        private DateOnly endDate = new DateOnly(2024, 11, 13);
        private string reason = "Suspected cheater in speedruns.";


        [TestMethod] //SUCCESS
        public void CreateBanTest()
        {
            //Arrange
            userController.Create(user);
            userController.Create(admin);
            user = userController.GetUserFromUsername(user.Username);
            admin = userController.GetUserFromUsername(admin.Username);
            bool result;
            //Act
            Ban ban = new(startDate, endDate, reason, user, admin);
            result = banController.Create(ban);
            //Assert
            Assert.AreEqual(false, result);

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
            user = userController.GetUserFromUsername(user.Username);
            admin = userController.GetUserFromUsername(admin.Username);
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
            user = userController.GetUserFromUsername(user.Username);
            admin = userController.GetUserFromUsername(admin.Username);
            Ban ban = new(startDate, endDate, reason, user, admin);
            banController.Create(ban);
            //Act
            List<Ban> bans = banController.ReadAllSearch(user.Username).ToList();
            //Assert
            Assert.AreNotEqual(0, bans.Count);
        }
    }
}