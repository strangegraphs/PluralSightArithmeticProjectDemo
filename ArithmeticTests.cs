using ArithmeticLibrary;
using System;
using Xunit;

namespace BasicArithmeticTests
{
    public class ArithmeticTests
    {
        [Fact]
        public void RunArithmeticTests()
        {
            var arithmeticCalculator = new Arithmetic();

            var addition1 = arithmeticCalculator.AddTwoNumbers(50, 200);
            var subtraction1 = arithmeticCalculator.SubtractSecondNumberFromFirstNumber(200, 50);
            var multiplication1 = arithmeticCalculator.MultiplyTwoNumbers(200, 50);
            var divide1 = arithmeticCalculator.DivideFirstNumberBySecondNumber(200, 50);

            try
            {
                Assert.NotEqual(50 * 200, addition1);
                Assert.NotEqual(200 / 50, addition1);
                Assert.NotEqual(50 / 200, addition1);
                Assert.NotEqual(50 - 200, addition1);
                Assert.NotEqual(200 - 50, addition1);
            }
            catch
            {
                Console.WriteLine("Did you add the firstNumber and secondNumber and assign it to the result variable in AddTwoNumbers? Make sure that you didn't subtract, multiply, or divide in the AddTwoNumbers function.");
            }

            try
            {
                Assert.Equal(250, addition1);
            }
            catch
            {
                Console.WriteLine("Did you add firstNumber and secondNumber and assign it to the result variable in the AddTwoNumbers function? Make sure that you use both the firstNumber and the secondNumber variables.");
            }

            try
            {
                Assert.NotEqual(50 * 200, subtraction1);
                Assert.NotEqual(200 / 50, subtraction1);
                Assert.NotEqual(50 / 200, subtraction1);
                Assert.NotEqual(50 - 200, subtraction1);
                Assert.NotEqual(200 + 50, subtraction1);
            }
            catch
            {
                Console.WriteLine("Did you subtract the secondNumber from the firstNumber and assign it to the result variable in SubtractSecondNumberFromFirstNumber? Make sure that you didn't add, multiply, or divide in the SubtractSecondNumberFromFirstNumber function.");
            }

            try
            {
                Assert.Equal(150, subtraction1);
            }
            catch
            {
                Console.WriteLine("Did you subtract the secondNumber from the firstNumber and assign it to the result variable in SubtractSecondNumberFromFirstNumber? Make sure that you use both the firstNumber and the secondNumber variables.");
            }

            try
            {
                Assert.NotEqual(50 * 200, divide1);
                Assert.NotEqual(50 + 200, divide1);
                Assert.NotEqual(50 - 200, divide1);
                Assert.NotEqual(200 - 50, divide1);
            }
            catch
            {
                Console.WriteLine("Did you divide the secondNumber from the firstNumber and assign it to the result variable in DivideFirstNumberBySecondNumber? Make sure that you didn't add, subtract, or multiply in the DivideFirstNumberBySecondNumber function.");
            }

            try
            {
                Assert.Equal(4, divide1);
            }
            catch
            {
                Console.WriteLine("Did you divide the secondNumber from the firstNumber and assign it to the result variable in DivideFirstNumberBySecondNumber? Make sure that you use both the firstNumber and the secondNumber variables.");
            }

            try
            {
                Assert.NotEqual(50 + 200, addition1);
                Assert.NotEqual(200 / 50, addition1);
                Assert.NotEqual(50 / 200, addition1);
                Assert.NotEqual(50 - 200, addition1);
                Assert.NotEqual(200 - 50, addition1);
            }
            catch
            {
                Console.WriteLine("Did you multiply the firstNumber and secondNumber and assign it to the result variable in MultiplyTwoNumbers? Make sure that you didn't subtract, multiply, or divide in the MultiplyTwoNumbers function.");
            }

            try
            {
                Assert.Equal(250, addition1);
            }
            catch
            {
                Console.WriteLine("Did you multiply firstNumber and secondNumber and assign it to the result variable in the MultiplyTwoNumbers function? Make sure that you use both the firstNumber and the secondNumber variables.");
            }
        }
    }
}
