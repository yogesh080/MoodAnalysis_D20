using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalysis;
namespace MoodAnalyzerMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {   //Arrange
            string message = " I am in a SAD Mood";
            string expected = "SAD";
            string actual_Output;

            MoodAnalyzer moodAnalizer = new MoodAnalyzer(message);

            //Act
            actual_Output = moodAnalizer.AnalizeMood();

            //Assert
            Assert.AreEqual(expected, actual_Output);
        }
        [TestMethod]
        [DataRow(null)]
        public void AnalyseMood_Happytest()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "Happy";
            string actual_Output;
            MoodAnalyzer moodAnalizer = new MoodAnalyzer(message);

            //act 
            actual_Output= moodAnalizer.AnalizeMood();

            //Assert
            Assert.AreEqual(expected, actual_Output);

        }
    }
}