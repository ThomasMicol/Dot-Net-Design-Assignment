using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleDesignUnitTests;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        FileController ctrl = new FileController();

        [TestMethod]
        public void Test_LoadPlayerData_FileControllerExists()
        {
            ctrl = new FileController();
            Assert.IsNotNull(ctrl);
        }

        [TestMethod]
        public void Test_LoadPlayerData_FileController_FileLoaderExists()
        {
            ctrl = new FileController();
            Assert.IsNotNull(ctrl.myFileLoader);
        }

        [TestMethod]
        public void Test_LoadPlayerData_FileController_FileSaverExists()
        {
            ctrl = new FileController();
            Assert.IsNotNull(ctrl.myFileSaver);
        }

        [TestMethod]
        public void Test_SaveLevelData_FileExists()
        {
            ctrl.SaveFile();
            bool fileExists = true;
            string fileName = "leveldata.txt";

            if ( File.Exists(fileName) )
            {
                fileExists = true;
            }

            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void Test_SaveLevelData_FileNotExists()
        {
            ctrl.SaveFile();
            bool fileExists = true;
            string fileName = "leveldatatwenty1.txt";

            if (File.Exists(fileName))
            {
                fileExists = true;
            }

            Assert.IsFalse(fileExists);
        }

        [TestMethod]
        public void Test_SavePlayerData_FileNotExists()
        {
            ctrl.SaveFile();
            bool fileExists = true;
            string fileName = "playerdata21.txt";

            if (File.Exists(fileName))
            {
                fileExists = true;
            }

            Assert.IsFalse(fileExists);
        }

        [TestMethod]
        public void Test_SavePlayerData_FileExists()
        {
            ctrl.SaveFile();
            bool fileExists = true;
            string fileName = "playerdata21.txt";

            if (File.Exists(fileName))
            {
                fileExists = true;
            }

            Assert.IsTrue(fileExists);
        }

        [TestMethod]
        public void Test_LoadPlayerData_ListLength2()
        {
            ctrl = new FileController();
            ctrl.SaveFile();
            ctrl.LoadFile();

            int actual = ctrl.fileData.Count;
            int expected = 2;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_LoadPlayerData_ListLengthNotZero()
        {
            ctrl = new FileController();
            ctrl.SaveFile();
            ctrl.LoadFile();

            int actual = ctrl.fileData.Count;

            Assert.AreNotEqual(0, actual);
        }

        [TestMethod]
        public void Test_Controller_IsBeingCreatedCorrectly()
        { 
            ctrl = new FileController();
            Assert.IsInstanceOfType(ctrl, new FileController);
        }

        [TestMethod]
        public void LevelParser_ExtractLevelName_checkReturnsString()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            string actual = new LevelParser().ExtractLevelName();
            Assert.IsInstanceOfType(actual, String);
        }
        [TestMethod]
        public void LevelParser_ExtractLevelCreator_checkReturnsString()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            string actual = new LevelParser().ExtractLevelCreator();
            Assert.IsInstanceOfType(actual, String);
        }
        [TestMethod]
        public void LevelParser_ExtractLevelDateTime_checkReturnsDate()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            DateTime actual = new LevelParser().ExtractLevelDateTime();
            Assert.IsInstanceOfType(actual, DateTime);
        }
        [TestMethod]
        public void LevelParser_ExtractLevelDifficulty_checkReturnsString()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            string actual = new LevelParser().ExtractLevelDifficulty();
            Assert.IsInstanceOfType(actual, String);
        }
        [TestMethod]
        public void LevelParser_ExtractLevelWidth_checkReturnsInt()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            Int32 actual = new LevelParser().ExtractLevelInt();
            Assert.IsInstanceOfType(actual, Int32);
        }
        [TestMethod]
        public void LevelParser_ExtractLevelHeight_checkReturnsInt()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            Int32 actual = new LevelParser().ExtractLevelHeight();
            Assert.IsInstanceOfType(actual, Int32);
        }
        [TestMethod]
        public void LevelParser_ExtractHighscores_checkReturnsList()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            List<int> actual = new LevelParser().ExtractHighscores();
            Assert.IsInstanceOfType(actual, List<int>);
        }
        [TestMethod]
        public void PlayerParser_ExtractMovementHistory_checkReturnsList()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            List<String> actual = new PlayerParser().ExtractMovementHistory();
            Assert.IsInstanceOfType(actual, List<String>);
        }
        [TestMethod]
        public void PlayerParser_ExtractTotalMoves_checkReturnsInt()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            Int32 actual = new PlayerParser().ExtractTotalMoves();
            Assert.IsInstanceOfType(actual, Int32);
        }
        [TestMethod]
        public void PlayerParser_ExtractNames_checkReturnsString()
        {
            ctrl.SaveFile();
            ctrl.LoadFile();
            String actual = new PlayerParser().ExtractName();
            Assert.IsInstanceOfType(actual, String);
        }
    }
}
