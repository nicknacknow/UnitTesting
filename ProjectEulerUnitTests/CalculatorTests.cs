using ProjectEulerSolutions;

namespace ProjectEulerUnitTests
{
    public class CalculatorTests
    {
        private static Calculator calc;
        [OneTimeSetUp] // tells us when this function should be called
        public void OneTimeSetup() // runs before a test runs - initate stuff
        {
            // Arrange
            calc = new Calculator();
        }

        [Test]
        public void CheckMultiplesOfThree([Range(-3000, 3000, 3)] int _this)
        {
            // Act
            bool result = calc.CheckThisIsMultipleOfThat(_this, 3);
            
            // Assert
            Assert.IsTrue(result); // if true, pass, if not, fail.


            //Assert.Pass(); // syntax we gotta learn for unit testing . . . pass the test
        }

        [Test]
        public void CheckMultiplesOfFive([Range(-5000, 5000, 5)] int _this)
        {
            // Act
            bool result = calc.CheckThisIsMultipleOfThat(_this, 5);

            // Assert
            Assert.IsTrue(result); // if true, pass, if not, fail.


            //Assert.Pass(); // syntax we gotta learn for unit testing . . . pass the test
        }

        [Test]
        public void CheckIsPalindrome([Values(0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171, 181, 191, 202)] int _this)
        {
            // Act
            bool result = calc.IsPalindrome(_this);

            // Assert
            Assert.IsTrue(result);
        }
    }
}