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
    }
}