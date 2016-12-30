using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FizzBuzz.library;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When1_Returns1()
        {
            int input = 1;
            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual("1", output);
        }

        [Test]
        public void Buzzer_WhenDefault_ReturnsInput([Values(1,2,4)]int input)
        {
            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual("Fizz", output);
        }
        
    }
}
