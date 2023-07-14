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
        MoodAnalyse moodAnalyse = new MoodAnalyse();
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string result = moodAnalyse.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenMood_ShouldReturnHappy()
        {

            string result = moodAnalyse.AnalyseMood("I am in Any Mood");
            Assert.AreEqual(result, "Happy");
        }



    }
}
