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
    public class UnitTestUserController
    {
        private string username = "catalin2";
        private string password = "Catalin";
        private string email = "testuser@gmail.com";

        private string adminUsername = "catalin";
        private string adminPassword = "12345";
        private string adminEmail = "catalin@gmail.com";


        private User DefaultUser
        {
            get
            {
                return new User(username, password, email, false);
            }
        }
        private User DefaultAdmin
        {
            get
            {
                return new User(adminUsername, adminPassword, adminEmail, true);
            }
        }

        [TestMethod] //SUCCESS
        public void CreateTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            bool result;
            //Act
            result = userController.Create(user);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod] //EDGE CASE
        public void CreateNullTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = null;
            bool result;
            //Act
            result = userController.Create(user);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod] //EDGE CASE
        public void CreateDuplicateTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            bool result;
            //Act
            userController.Create(user);
            result = userController.Create(user);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod] //SUCCESS
        public void UpdateTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            user.Bio = "Speedrunner";
            bool result;
            //Act
            result = userController.Update(user);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod] //EDGE CASE
        public void UpdateNullTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            user = null;
            bool result;
            //Act
            result = userController.Update(user);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]  //EDGE CASE
        public void UpdateNonExistentTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user1 = DefaultUser;
            userController.Create(user1);
            User user2 = DefaultUser;
            user2.Bio = "Speedrunner";
            bool result;
            //Act
            result = userController.Update(user2);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod] //SUCCESS
        public void ReadAllTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user1 = DefaultUser;
            userController.Create(user1);
            User user2 = DefaultUser;
            userController.Create(user2);
            //Act
            User[] users = userController.ReadAll();
            //Assert
            CollectionAssert.AreEquivalent(new User[] { user1, user2 }, users);
        }
        [TestMethod] //EDGE CASE
        public void ReadAllIsEmptyTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            //Act
            User[] users = userController.ReadAll();
            //Assert
            CollectionAssert.AreEquivalent(new User[] { }, users);
        }
        [TestMethod] //SUCCESS
        public void GetUserFromUsernameTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            //Act
            User result = userController.GetUserFromUsername(user.Username);
            //Assert
            Assert.AreEqual(user, result);
        }
        [TestMethod] //EDGE CASE
        public void GetUserFromUsernameNullTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            //Act
            User result = userController.GetUserFromUsername("");
            //Assert
            Assert.AreEqual(null, result);
        }
        [TestMethod] //SUCCESS
        public void GetUserFromIdTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            //Act
            User result = userController.GetUserFromId(user.Id);
            //Assert
            Assert.AreEqual(user, result);
        }
        [TestMethod] //EDGE CASE
        public void GetUserFromIdNullTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            //Act
            User result = userController.GetUserFromId(0);
            //Assert
            Assert.AreEqual(null, result);
        }
        [TestMethod] //SUCCESS
        public void DeleteTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            bool result;
            //Act
            result = userController.Delete(user);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod] //EDGE CASE
        public void DeleteNullTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            userController.Create(user);
            user = null;
            bool result;
            //Act
            result = userController.Delete(user);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod] //EDGE CASE
        public void DeleteDuplicateTest()
        {
            //Arrange
            UserController userController = new UserController(new UnitTestUserDAL());
            User user = DefaultUser;
            bool result;
            //Act
            userController.Delete(user);
            result = userController.Delete(user);
            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
