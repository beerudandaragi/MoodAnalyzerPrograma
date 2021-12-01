using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer1
{
    public class MoodAnalyzer
    {
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";

            else
                return "HAPPY";
        }
    }
}