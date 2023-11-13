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
    public class UnitTestSubmissionController
    {
        private User user = new User("catalin2", "Catalin", "testuser@gmail.com", false);
        private Game game = new Game("Re-Volt", "Acclaim Studios London", new DateOnly(1999, 9, 3), $"{EnumGenre.Racing.ToString()}", $"{EnumPlatform.Android}, {EnumPlatform.iOS},{EnumPlatform.N64}, {EnumPlatform.Playstation}, {EnumPlatform.PC}", "https://www.youtube.com/watch?v=aTsFnNZKFZg", "https://upload.wikimedia.org/wikipedia/en/5/5b/Re-Volt_Coverart.jpg", "https://re-volt.io/user/pages/home/home/race.jpg");
        private DateOnly date = new DateOnly(2023, 11, 12);
        private TimeSpan time1 = new TimeSpan(1, 0, 0);
        private TimeSpan time2 = new TimeSpan(0, 30, 15);
        private EnumPlatform platform = EnumPlatform.PC;

        private string link1 = "https://www.youtube.com/watch?v=4MtXim3c-NU";
        private string link2 = "https://www.youtube.com/watch?v=Lbtc5mAjrO8";
        private bool tas = false;
        private bool glitchless = true;
        private bool anyPercent = true;
        private RankedSubmission DefaultRanked1
        {
            get
            {
                return new RankedSubmission(user, game, date, time1, platform, link1);
            }
        }

        private RankedSubmission DefaultRanked2
        {
            get
            {
                return new RankedSubmission(user, game, date, time2, platform, link2);
            }
        }

        private UnrankedSubmission DefaultUnranked
        {
            get
            {
                return new UnrankedSubmission(user, game, date, time1, platform, tas, glitchless, anyPercent);
            }
        }

        [TestMethod] //SUCCESS
        public void CreateRankedTest()
        {
            //Arrange
            SubmissionController submissionController = new(new UnitTestSubmissionDAL());
            RankedSubmission submission = DefaultRanked1;
            submission.Rank = submissionController.CalculateRank(submission);
            bool result;
            //Act
            result = submissionController.Create(submission);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //EDGE CASE
        public void CreateRankedNullTest()
        {
            //Arrange
            SubmissionController submissionController = new(new UnitTestSubmissionDAL());
            RankedSubmission submission = null;
            bool result;
            //Act
            result = submissionController.Create(submission);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //EDGE CASE
        public void CreateRankedDuplicateTest()
        {
            //Arrange
            SubmissionController submissionController = new(new UnitTestSubmissionDAL());
            RankedSubmission submission = DefaultRanked1;
            submission.Rank = submissionController.CalculateRank(submission);
            bool result;
            //Act
            submissionController.Create(submission);
            result = submissionController.Create(submission);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //SUCCESS
        public void CreateUnrankedTest()
        {
            //Arrange
            SubmissionController submissionController = new(new UnitTestSubmissionDAL());
            UnrankedSubmission submission = DefaultUnranked;
            bool result;
            //Act
            result = submissionController.Create(submission);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //EDGE CASE
        public void CreateUnrankedNullTest()
        {
            //Arrange
            SubmissionController submissionController = new(new UnitTestSubmissionDAL());
            UnrankedSubmission submission = null;
            bool result;
            //Act
            result = submissionController.Create(submission);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //EDGE CASE
        public void CreateUnrankedDuplicateTest()
        {
            //Arrange
            SubmissionController submissionController = new(new UnitTestSubmissionDAL());
            UnrankedSubmission submission = DefaultUnranked;
            bool result;
            //Act
            submissionController.Create(submission);
            result = submissionController.Create(submission);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod] //SUCCESS
        public void PredictRankTest()
        {
            //Arrange
            SubmissionController submissionController = new SubmissionController(new UnitTestSubmissionDAL());
            RankedSubmission rankedSubmission1 = DefaultRanked1;
            //Act
            rankedSubmission1.Rank = submissionController.PredictRank(rankedSubmission1)[0];
            //Assert
            Assert.AreEqual(1, rankedSubmission1.Rank);
        }

        [TestMethod] //EDGE CASE
        public void PredictRankNullTest()
        {
            //Arrange
            SubmissionController submissionController = new SubmissionController(new UnitTestSubmissionDAL());
            RankedSubmission rankedSubmission1 = DefaultRanked1;
            submissionController.Create(rankedSubmission1);
            RankedSubmission rankedSubmission2 = null;
            //Act
            int result = submissionController.PredictRank(rankedSubmission2)[0];
            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod] //SUCCESS
        public void CalculateRankTest()
        {
            //Arrange
            SubmissionController submissionController = new SubmissionController(new UnitTestSubmissionDAL());
            RankedSubmission rankedSubmission1 = DefaultRanked1;
            RankedSubmission rankedSubmission2 = DefaultRanked2;
            rankedSubmission2.Rank = submissionController.CalculateRank(rankedSubmission2);
            submissionController.Create(rankedSubmission2);
            //Act
            rankedSubmission1.Rank = submissionController.CalculateRank(rankedSubmission1);
            submissionController.Create(rankedSubmission1);
            //Assert
            Assert.AreEqual(1, rankedSubmission1.Rank);
        }

        [TestMethod] //EDGE CASE
        public void CalculateRankNullTest()
        {
            //Arrange
            SubmissionController submissionController = new SubmissionController(new UnitTestSubmissionDAL());
            RankedSubmission rankedSubmission1 = DefaultRanked1;
            rankedSubmission1.Rank = submissionController.CalculateRank(rankedSubmission1);
            submissionController.Create(rankedSubmission1);
            RankedSubmission rankedSubmission2 = null;
            //Act
            int result = submissionController.CalculateRank(rankedSubmission2);
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
