using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer1;

namespace MoodAnalyzertProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MsgSadMood()
        {
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }

        public void MsgHaapyMood()
        {
            string msg = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
    }
}