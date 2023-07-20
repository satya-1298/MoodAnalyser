using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static MoodAnalyzer_Demo.MoodAnalyseCustom_Exception;

namespace MoodAnalyzer_Demo
{
    public  class MoodAnalyserFactor:Exception
    {
       
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
               string pattern = @"." + constructorName + "$";
                Match result = Regex.Match(className, pattern);

                if (result.Success)
                {
                    try
                    {
                        Assembly executing = Assembly.GetExecutingAssembly();
                        Type moodAnalyseType = executing.GetType(className);
                        return Activator.CreateInstance(moodAnalyseType);
                    }
                    catch (ArgumentNullException)
                    {
                        throw new MoodAnalyseCustom_Exception("Class not found", MoodAnalyser_ExceptionType.NO_SUCH_CLASS);
                    }

                }
                else
                {
                    throw new MoodAnalyseCustom_Exception("Constructor not found",MoodAnalyser_ExceptionType.NO_SUCH_METHOD);

                }            
        }
    }
}

