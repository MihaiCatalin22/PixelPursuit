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
    public class SubmissionManagementTests
    {
        private Mock<ISubmissionManagement> mockSubmissionManagement;
        private SubmissionController submissionController;

        public SubmissionManagementTests()
        {
            mockSubmissionManagement = new Mock<ISubmissionManagement>();
            submissionController = new SubmissionController(mockSubmissionManagement.Object);
        }
        [Fact]
        public void CreateRankedSubmission_ShouldReturnTrue_WhenSubmissionIsValid()
        {
            var validSubmission = new RankedSubmission(
                new User(1, "JohnDoe", "password123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#FFFFFF", "profile.jpg", "Bio", false, false),
                new Game(1, "GameName", "GameCompany", DateOnly.FromDateTime(DateTime.Now), "trailerLink", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Action", "PC", "pictureLink", "backgroundLink"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(2),
                EnumPlatform.PC,
                "link"
            );
            mockSubmissionManagement.Setup(sm => sm.Create(It.IsAny<RankedSubmission>())).Returns(true);

            var result = submissionController.Create(validSubmission);
            Assert.True(result);
        }

        [Fact]
        public void CreateRankedSubmission_ShouldReturnFalse_WhenSubmissionIsNull()
        {
            var result = submissionController.Create((RankedSubmission)null);
            Assert.False(result);
        }
        [Fact]
        public void CreateUnrankedSubmission_ShouldReturnTrue_WhenSubmissionIsValid()
        {
            var validSubmission = new UnrankedSubmission(
                new User(2, "Bob", "password456", "bob@example.com", DateOnly.FromDateTime(DateTime.Now), "#000000", "profile2.jpg", "Bio2", false, false),
                new Game(2, "GameName2", "GameCompany2", DateOnly.FromDateTime(DateTime.Now), "trailerLink2", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Adventure", "Xbox", "pictureLink2", "backgroundLink2"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(1),
                EnumPlatform.Xbox,
                true, false, true
            );
            mockSubmissionManagement.Setup(sm => sm.Create(It.IsAny<UnrankedSubmission>())).Returns(true);

            var result = submissionController.Create(validSubmission);
            Assert.True(result);
        }

        [Fact]
        public void CreateUnrankedSubmission_ShouldReturnFalse_WhenSubmissionIsNull()
        {
            var result = submissionController.Create((UnrankedSubmission)null);
            Assert.False(result);
        }
        [Fact]
        public void ReadRecentByUsername_ShouldReturnSubmissions()
        {
            var submissions = new Submission[] {
            new RankedSubmission(new User(1, "JohnDoe", "password123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#FFFFFF", "profile.jpg", "Bio", false, false),
            new Game(1, "GameName", "GameCompany", DateOnly.FromDateTime(DateTime.Now), "trailerLink", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Action", "PC", "pictureLink", "backgroundLink"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(2),
            EnumPlatform.PC,
            "link")
            };
            mockSubmissionManagement.Setup(sm => sm.ReadRecent("John")).Returns(submissions);

            var result = submissionController.ReadRecent("John");
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void ReadRecentByUserId_ShouldReturnSubmissions()
        {
            var submissions = new Submission[] {
            new UnrankedSubmission(new User(2, "Bob", "password456", "bob@example.com", DateOnly.FromDateTime(DateTime.Now), "#000000", "profile2.jpg", "Bio2", false, false),
            new Game(2, "GameName2", "GameCompany2", DateOnly.FromDateTime(DateTime.Now), "trailerLink2", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Adventure", "Xbox", "pictureLink2", "backgroundLink2"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(1),
            EnumPlatform.Xbox,
            true, false, true)
            };
            mockSubmissionManagement.Setup(sm => sm.ReadRecent(2)).Returns(submissions);

            var result = submissionController.ReadRecent(2);
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void ReadByGame_ShouldReturnUnrankedSubmissions()
        {
            var gameId = 2;
            var username = "Bob";
            var submissions = new UnrankedSubmission[] {
            new UnrankedSubmission(new User(2, "Bob", "password456", "bob@example.com", DateOnly.FromDateTime(DateTime.Now), "#000000", "profile2.jpg", "Bio2", false, false),
            new Game(2, "GameName2", "GameCompany2", DateOnly.FromDateTime(DateTime.Now), "trailerLink2", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Adventure", "Xbox", "pictureLink2", "backgroundLink2"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(1),
            EnumPlatform.Xbox,
            true, false, true)
            };
            mockSubmissionManagement.Setup(sm => sm.ReadByGame(gameId, username)).Returns(submissions);

            var result = submissionController.ReadByGame(gameId, username);
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void ReadByUser_ShouldReturnUnrankedSubmissions()
        {
            var userId = 1;
            var submissions = new UnrankedSubmission[] {
            new UnrankedSubmission(new User(1, "JohnDoe", "password123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#FFFFFF", "profile.jpg", "Bio", false, false),
            new Game(1, "GameName", "GameCompany", DateOnly.FromDateTime(DateTime.Now), "trailerLink", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Action", "PC", "pictureLink", "backgroundLink"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(2),
            EnumPlatform.PC,
            true, false, true)
            };
            mockSubmissionManagement.Setup(sm => sm.ReadByUser(userId)).Returns(submissions);

            var result = submissionController.ReadByUser(userId);
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void ReadRanked_ShouldReturnRankedSubmission()
        {
            var submissionId = 3;
            var submission = new RankedSubmission(
                3,
                new User(3, "JohnDoe", "pass123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#ABCDEF", "profile3.jpg", "Bio3", false, true),
                new Game(3, "GameName3", "GameCompany3", DateOnly.FromDateTime(DateTime.Now), "trailerLink3", 10, 20, TimeSpan.FromHours(1), TimeSpan.FromHours(30), "RPG", "PS5", "pictureLink3", "backgroundLink3"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(1.5),
                EnumPlatform.Playstation5,
                true,
                false,
                "link3",
                1
            );
            mockSubmissionManagement.Setup(sm => sm.ReadRanked(submissionId)).Returns(submission);

            var result = submissionController.ReadRanked(submissionId);
            Assert.NotNull(result);
            Assert.Equal(submissionId, result.Id);
        }
        [Fact]
        public void ReadRankedByUser_ShouldReturnRankedSubmissions()
        {
            var userId = 3;
            var submissions = new RankedSubmission[] {
            new RankedSubmission(
            3,
            new User(3, "JohnDoe", "pass123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#ABCDEF", "profile3.jpg", "Bio3", false, true),
            new Game(3, "GameName3", "GameCompany3", DateOnly.FromDateTime(DateTime.Now), "trailerLink3", 10, 20, TimeSpan.FromHours(1), TimeSpan.FromHours(30), "RPG", "PS5", "pictureLink3", "backgroundLink3"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(1.5),
            EnumPlatform.Playstation5,
            true,
            false,
            "link3",
            1     
            )
            };
            mockSubmissionManagement.Setup(sm => sm.ReadRankedByUser(userId)).Returns(submissions);

            var result = submissionController.ReadRankedByUser(userId);
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void ReadPendingAdmin_ShouldReturnPendingRankedSubmissions()
        {
            var pendingSearch = 1;
            var usernameSearch = "JohnDoe";
            var gameSearch = "GameName";
            var platformSearch = EnumPlatform.PC.ToString();
            var submissions = new RankedSubmission[] {
            new RankedSubmission(
            1,
            new User(1, "JohnDoe", "password123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#FFFFFF", "profile.jpg", "Bio", false, false),
            new Game(1, "GameName", "GameCompany", DateOnly.FromDateTime(DateTime.Now), "trailerLink", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Action", "PC", "pictureLink", "backgroundLink"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(2),
            EnumPlatform.PC,
            false,
            true,  
            "link",
            0     
            )
             };
            mockSubmissionManagement.Setup(sm => sm.ReadPendingAdmin(pendingSearch, usernameSearch, gameSearch, platformSearch)).Returns(submissions);

            var result = submissionController.ReadPendingAdmin(pendingSearch, usernameSearch, gameSearch, platformSearch);
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void ReadRankedByGame_ShouldReturnRankedSubmissionsForGame()
        {
            var gameId = 3;
            var submissions = new RankedSubmission[] {
            new RankedSubmission(
            new User(3, "Charlie", "pass789", "charlie@example.com", DateOnly.FromDateTime(DateTime.Now), "#ABCDEF", "profile3.jpg", "Bio3", false, true),
            new Game(3, "GameName3", "GameCompany3", DateOnly.FromDateTime(DateTime.Now), "trailerLink3", 10, 20, TimeSpan.FromHours(1), TimeSpan.FromHours(30), "RPG", "PS5", "pictureLink3", "backgroundLink3"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(1.5),
            EnumPlatform.Playstation5,
            "link3"
            )
            };
            mockSubmissionManagement.Setup(sm => sm.ReadRankedByGame(gameId, It.IsAny<string>())).Returns(submissions);

            var result = submissionController.ReadRankedByGame(gameId, "Charlie");
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void UpdateRanked_ShouldReturnTrue_WhenSubmissionIsValid()
        {
            var submission = new RankedSubmission(
                new User(3, "Charlie", "pass789", "charlie@example.com", DateOnly.FromDateTime(DateTime.Now), "#ABCDEF", "profile3.jpg", "Bio3", false, true),
                new Game(3, "GameName3", "GameCompany3", DateOnly.FromDateTime(DateTime.Now), "trailerLink3", 10, 20, TimeSpan.FromHours(1), TimeSpan.FromHours(30), "RPG", "PS5", "pictureLink3", "backgroundLink3"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(1.5),
                EnumPlatform.Playstation5,
                "link3"
            );
            mockSubmissionManagement.Setup(sm => sm.UpdateRanked(submission)).Returns(true);

            var result = submissionController.UpdateRanked(submission);
            Assert.True(result);
        }
        [Fact]
        public void Delete_ShouldReturnTrue_WhenSubmissionIsValid()
        {
            var submission = new RankedSubmission(
                new User(3, "Charlie", "pass789", "charlie@example.com", DateOnly.FromDateTime(DateTime.Now), "#ABCDEF", "profile3.jpg", "Bio3", false, true),
                new Game(3, "GameName3", "GameCompany3", DateOnly.FromDateTime(DateTime.Now), "trailerLink3", 10, 20, TimeSpan.FromHours(1), TimeSpan.FromHours(30), "RPG", "PS5", "pictureLink3", "backgroundLink3"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(1.5),
                EnumPlatform.Playstation5,
                "link3"
            );
            mockSubmissionManagement.Setup(sm => sm.Delete(submission)).Returns(true);

            var result = submissionController.Delete(submission);
            Assert.True(result);
        }
        [Fact]
        public void ReadApprovedAdmin_ShouldReturnApprovedRankedSubmissions()
        {
            var approvedSearch = 1;
            var usernameSearch = "Bob";
            var gameSearch = "GameName2";
            var platformSearch = EnumPlatform.Xbox.ToString();
            var submissions = new RankedSubmission[] {
            new RankedSubmission(
            new User(2, "Bob", "password456", "bob@example.com", DateOnly.FromDateTime(DateTime.Now), "#000000", "profile2.jpg", "Bio2", false, false),
            new Game(2, "GameName2", "GameCompany2", DateOnly.FromDateTime(DateTime.Now), "trailerLink2", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Adventure", "Xbox", "pictureLink2", "backgroundLink2"),
            DateOnly.FromDateTime(DateTime.Now),
            TimeSpan.FromHours(1),
            EnumPlatform.Xbox,
            "link2"
            )
            };
            mockSubmissionManagement.Setup(sm => sm.ReadApprovedAdmin(approvedSearch, usernameSearch, gameSearch, platformSearch)).Returns(submissions);

            var result = submissionController.ReadApprovedAdmin(approvedSearch, usernameSearch, gameSearch, platformSearch);
            Assert.NotNull(result);
            Assert.Single(result);
        }
        [Fact]
        public void CalculateRank_ShouldReturnValidRank()
        {
            var submission = new RankedSubmission(
                new User(1, "JohnDoe", "password123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#FFFFFF", "profile.jpg", "Bio", false, false),
                new Game(1, "GameName", "GameCompany", DateOnly.FromDateTime(DateTime.Now), "trailerLink", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Action", "PC", "pictureLink", "backgroundLink"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(2),
                EnumPlatform.PC,
                "link"
            );
            mockSubmissionManagement.Setup(sm => sm.ReadRankedByGame(It.IsAny<int>(), It.IsAny<string>())).Returns(new RankedSubmission[] { submission });

            var rank = submissionController.CalculateRank(submission);
            Assert.True(rank > 0);
        }
        [Fact]
        public void PredictRank_ShouldReturnValidRankAndPosition()
        {
            var submission = new RankedSubmission(
                new User(1, "JohnDoe", "password123", "john@example.com", DateOnly.FromDateTime(DateTime.Now), "#FFFFFF", "profile.jpg", "Bio", false, false),
                new Game(1, "GameName", "GameCompany", DateOnly.FromDateTime(DateTime.Now), "trailerLink", 0, 0, TimeSpan.Zero, TimeSpan.Zero, "Action", "PC", "pictureLink", "backgroundLink"),
                DateOnly.FromDateTime(DateTime.Now),
                TimeSpan.FromHours(2),
                EnumPlatform.PC,
                "link"
            );
            mockSubmissionManagement.Setup(sm => sm.ReadRankedByGame(It.IsAny<int>(), It.IsAny<string>())).Returns(new RankedSubmission[] { submission });

            var result = submissionController.PredictRank(submission);
            Assert.False(result[0] > 0);
            Assert.True(result[1] >= 0);
        }
    }
}
