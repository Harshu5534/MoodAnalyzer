using MoodAnalyzerProblems;
using NUnit.Framework;

namespace TestMood
{
    public class MoodAnalyse
    {
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnSad()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer("I am in Sad Mood");
            string actual = analyzer.AnalyseMood();
            Assert.Pass(actual, "Sad");
        }
        [Test]
        public void GivenInputIsString_WhenTestAnalyseMood_ShouldReturnReturnHappy()
        {
            MoodAnalyzer analyzer = new MoodAnalyzer("I am in Happy Mood");
            string actual = analyzer.AnalyseMood();
            Assert.Pass(actual, "Happy");
        }
    }
}