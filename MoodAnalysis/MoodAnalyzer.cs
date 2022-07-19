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
            if (this.message.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }

        }

    }
}
