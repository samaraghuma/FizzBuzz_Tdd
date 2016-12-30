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
        [TestMethod]       
        public void Buzzer_WhenDefault_ReturnsInput(int input)
        {
          
            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [TestMethod]
        public void Buzzer_When1_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual("Fizz", output);
        }

    }
}
