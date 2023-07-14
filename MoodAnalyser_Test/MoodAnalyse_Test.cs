using MoodAnalyzer_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Test
{
    public class MoodAnalyse_Test
    {
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenMood_ShouldReturnHappy()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Happy Mood");
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }



    }
}
