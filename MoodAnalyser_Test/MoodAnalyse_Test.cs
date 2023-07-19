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
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {

            MoodAnalyse moodAnalyse = new MoodAnalyse(null);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMessage_ShouldThrowCustomException()
        {
            try
            {
                //Arrange - it will set up the testing object
                MoodAnalyse moodAnalyse = new MoodAnalyse(null);
                //Act - it will perform the actual work what we want test
                string result = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyseCustom_Exception ex)
            {
                //Assert - which verify the result  by equal actual and expected output
                Assert.AreEqual(ex.Message, "Message should not be null");

            }
        }
        [Test]
        public void GivenEmptyMessage_ShouldThrowCustomException()
        {
            try
            {
                //Arrange - it will set up the testing object
                MoodAnalyse moodAnalyse = new MoodAnalyse(" ");
                //Act - it will perform the actual work what we want test
                string result = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyseCustom_Exception ex)
            {
                //Assert - which verify the result  by equal actual and expected output
                Assert.AreEqual(ex.Message, "Message should not be Empty");

            }
        }



    }
}
