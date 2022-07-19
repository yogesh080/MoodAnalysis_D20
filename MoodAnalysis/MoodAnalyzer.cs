using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalysis
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer(string message)
        {
            this.message = message;

        }
        public string AnalizeMood()
        {
            try
            {
                if (this.message.Equals(String.Empty))
                {
                    throw new MoodAnalyzersException(MoodAnalyzersException.ExceptionType.NULL_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzersException(MoodAnalyzersException.ExceptionType.NULL_MESSAGE, "Mood should not be null");

            }

        }

    }
}



