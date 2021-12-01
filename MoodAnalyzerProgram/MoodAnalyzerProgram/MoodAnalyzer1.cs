using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer1
{
    public class MoodAnalyzer
    {
        public string msg;
        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }

        public string AnalyseMood()
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";

            else
                return "HAPPY";
        }

    }
}