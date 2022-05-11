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
    }
}