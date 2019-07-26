using System;
using Contract;
using Rules;
using Xunit;

namespace Test
{
    public class FizzBuzzCalculatorTest
    {
        [Fact]
        public void FizzBuzz_1_1()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            string result = fizzBuzzCalculator.FizzBuzz(1);

            //Assert
            Assert.Equal("1", result);
        }  

        [Fact]
        public void FizzBuzz_100_fizz()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            string result = fizzBuzzCalculator.FizzBuzz(100);

            //Assert
            Assert.Equal("fizz", result);
        }  

        [Fact]
        public void FizzBuzz_5_fizz()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            string result = fizzBuzzCalculator.FizzBuzz(5);

            //Assert
            Assert.Equal("fizz", result);
        }  

        [Fact]
        public void FizzBuzz_7_buzz()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            string result = fizzBuzzCalculator.FizzBuzz(7);

            //Assert
            Assert.Equal("buzz", result);
        }  

        [Fact]
        public void FizzBuzz_35_fizzbuzz()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            string result = fizzBuzzCalculator.FizzBuzz(35);

            //Assert
            Assert.Equal("fizzbuzz", result);
        }  

        [Fact]
        public void FizzBuzz_0_throwsException()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            Action action = () => fizzBuzzCalculator.FizzBuzz(0);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(action);
        } 

        [Fact]
        public void FizzBuzz_101_throwsException()
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            Action action = () => fizzBuzzCalculator.FizzBuzz(101);

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(action);
        } 

        [Theory]
        [InlineData(1,  "1"),
         InlineData(100,"fizz"),
         InlineData(7,  "buzz"),
         InlineData(35, "fizzbuzz")]
        public void FizzBuzz_validInput_fizzOrBuzzOrFizzbuzzOrNumber(int input, string expectation) 
        {
            // Arrange
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();

            //Act
            string result = fizzBuzzCalculator.FizzBuzz(input);

            //Assert
            Assert.Equal(expectation, result);
        }
    }
}
