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
        //Tc 3.1
        [TestMethod]
        public void Given_null_should_throw_moodAnalysisExceotion()
        {
            try
            {
                string message = null;
                MoodAnalyzer moodAnalizer = new MoodAnalyzer(message);
                string actual_Output = moodAnalizer.AnalizeMood();


            }
            catch (MoodAnalyzersException e)
            {
                Assert.AreEqual("mood Should not be null", e.Message);
            }
        }
        //TC 3.2
        //[TestMethod]
        //public void Given_Empty_should_throw_MoodAnalysisException_EmptyMood()
        //{
        //    try
        //    {
        //        string message = "";
        //        MoodAnalyzer moodAnalizer = new MoodAnalyzer(message);
        //        string actual_Output = moodAnalizer.AnalizeMood();


        //    }
        //    catch (MoodAnalyzersException e)
        //    {
        //        Assert.AreEqual("mood Should not be empty", e.Message);
        //    }
        //}

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            
                string message = null;
                object expected = new MoodAnalyzer(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalysis.MoodAnalyzer", "MoodAnalyzer");
                expected.Equals(obj);
            
            
        }
    }
}