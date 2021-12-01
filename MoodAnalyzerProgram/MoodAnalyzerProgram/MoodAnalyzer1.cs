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
            try
            {
                if (msg.ToLower().Contains(""))
                    return "HAPPY";

                else
                    return "SAD";
            }
            catch (NullReferenceException msg)
            {
                return "Happy";
            }
        }
    }
}