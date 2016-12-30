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
        public void Buzzer_WhenDefault_ReturnsInput([Values(1, 2, 4, 7, 8)]int input)
        {
            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual(input.ToString(), output);
        }
        [Test]
        public void Buzzer_WhenDiv3_ReturnsFizz([Values(3, 6)] int input)
        {

            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual("Fizz", output);
        }
        [Test]
        public void Buzzer_WhenDiv5_ReturnsFizz([Values(5, 10)] int input)
        {

            string output = FizzBuzzer.Getvalue(input);
            Assert.AreEqual("Buzz", output);
        }
    }
}
