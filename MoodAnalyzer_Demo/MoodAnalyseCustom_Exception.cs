using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer_Demo
{
    //Custom exception are user defined exceptions use to customize the exception as
    //per the user needed.
    public class MoodAnalyseCustom_Exception:Exception
    {
        public enum MoodAnalyser_ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
        }
        public MoodAnalyser_ExceptionType type;
        //Base - This keyword  is used to access member of a base class  with in a derived class
        public MoodAnalyseCustom_Exception(string message, MoodAnalyser_ExceptionType type):base(message)
        {

            this.type = type; 

        }

    }
}
