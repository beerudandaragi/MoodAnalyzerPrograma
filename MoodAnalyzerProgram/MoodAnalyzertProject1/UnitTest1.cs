using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer1;

namespace MoodAnalyzertProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
    }
}