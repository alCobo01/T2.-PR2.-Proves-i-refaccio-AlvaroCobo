using System;
using T2_PR2_ClassLibrary;

namespace T2_PR2_MSTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void OverZero()
        {
            //Arrange
            double value = 32;
            //Act
            bool result = MyFunctions.IsUnderZero(value);
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UnderZero() 
        {
            //Arrange
            double value = -32;
            //Act
            bool result = MyFunctions.IsUnderZero(value);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CorrectArea()
        {
            //Arrange
            double width = 5;
            double height = 10;
            double expectedResult = 50;

            //Act
            double result = MyFunctions.CalculateArea(width, height);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CorrectCircumference()
        {
            //Arrange
            double radius = 5;
            double expectedResult = 2 * Math.PI * radius;

            //Act
            double result = MyFunctions.CalculateCircumference(radius);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}