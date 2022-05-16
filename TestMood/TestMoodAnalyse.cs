using MoodAnalyzerProblems;
using NUnit.Framework;

namespace TestMood
{
    public class TestMoodAnalyse
    {
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnEmpty()
        {
            try
            {
                MoodAnalyzer analyzer = new MoodAnalyzer("");
                string actual = analyzer.AnalyseMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnNull()
        {
            try
            {
                MoodAnalyzer analyzer = new MoodAnalyzer(null);
                string actual = analyzer.AnalyseMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Null");
            }
        }
        [Test]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyzer();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzerProblems.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyzerClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstrctor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyzerUsingParameterizedConstrctor("MoodAnalyzerProblems.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);
        }
        [Test]
        public void GivenHappyMoodShouldReturnHappy()
        {
            string expected = "Happy";
            string mood = MoodAnalyzerFactory.InvokeAnalyzerMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }
        [Test]
        public void GivenHappyMessage_WithReflector_ShouldReturn_Happy()
        {
            string result = MoodAnalyzerFactory.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }

    }
}