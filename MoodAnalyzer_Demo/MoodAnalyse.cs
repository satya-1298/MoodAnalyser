using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzer_Demo.MoodAnalyseCustom_Exception;

namespace MoodAnalyzer_Demo
{
    public class MoodAnalyse
    {
        string message;
        public MoodAnalyse(string message)
        {
            this.message = message;   
        }
        public   string  AnalyseMood()

        {
            try
            { 
                if (this.message.Equals(string.Empty))
                {
               
                    throw new MoodAnalyseCustom_Exception("Message should not be Empty", MoodAnalyser_ExceptionType.EMPTY_MOOD);
                }
                //My name is Sad
                if (message.Contains("Sad"))
                {

                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
           
            catch(NullReferenceException) 
            {
                 return "Happy";
                throw new MoodAnalyseCustom_Exception("Message should not be null", MoodAnalyser_ExceptionType.NULL_MOOD);
            }
        }
    }
}
