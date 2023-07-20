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
            Type type = typeof(MoodAnalyse);
           
            if (type.Name.Equals(constructorName))
            {
                ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                object instance = ctor.Invoke(new object[] { "HAPPY" });
                return instance;
            }
            else if (type.FullName.Equals(className))
            {
                throw new MoodAnalyseCustom_Exception("Constructor is Not Found",MoodAnalyser_ExceptionType.NO_SUCH_METHOD);
            }           
            else
            {
                throw new MoodAnalyseCustom_Exception("Class Not Found",MoodAnalyser_ExceptionType.NO_SUCH_CLASS);
            }

        }
    }
}

