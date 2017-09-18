using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDesignUnitTests;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class ValidatorUnitTest
    {
        LevelValidator LevelVal = new LevelValidator();
        PlayerValidator PlayerVal = new PlayerValidator();

        [TestMethod]
        public void Test_ValidateLevelName_FalseOnEmptyString()
        {
            boolean result = LevelVal.ValidateLevelName("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateLevelName_TrueOnValidString()
        {
            boolean result = LevelVal.ValidateLevelName("Level 1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateLevelDate_TrueOnTodayDate()
        {
            boolean result = LevelVal.ValidateLevelDate(DateTime.Now);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateLevelDate_FalseOnFutureDate()
        {
            boolean result = LevelVal.ValidateLevelDate(DateTime.Now.AddDays(1));
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateLevelDifficulty_TrueOnEasy()
        {
            boolean result = LevelVal.ValidateLevelDifficulty("Easy");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_ValidateLevelDifficulty_FalseOnEmptyString()
        {
            boolean result = LevelVal.ValidateLevelDifficulty("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateLevelWidth_FalseOnZero()
        {
            boolean result = LevelVal.ValidateLevelWidth(0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateLevelWidth_TrueOnOne()
        {
            boolean result = LevelVal.ValidateLevelWidth(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateLevelHeight_FalseOnZero()
        {
            boolean result = LevelVal.ValidateLevelHeight(0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateLevelHeight_TrueOnOne()
        {
            boolean result = LevelVal.ValidateLevelHeight(1);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateTotalMoves_FalseOnNegative()
        {
            boolean result = PlayerVal.ValidateTotalMoves(-1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateTotalMoves_TrueOnZero()
        {
            boolean result = PlayerVal.ValidateTotalMoves(0);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_ValidateName_FalseOnEmptyString()
        {
            boolean result = PlayerVal.ValidateName("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_ValidateName_TrueOnValidName()
        {
            boolean result = PlayerVal.ValidateName("FooBar1");
            Assert.IsTrue(result);
        }

    }
}
