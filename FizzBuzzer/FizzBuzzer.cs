using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.library;

namespace FizzBuzz.Library.Tests
{
    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod]
        public void Buzzer_When1_Returns1()
        {
            int input = 1;
            string output=FizzBuzzer.Getvalue(input);
            Assert.AreEqual("1", output);
        }
       
    }
}
