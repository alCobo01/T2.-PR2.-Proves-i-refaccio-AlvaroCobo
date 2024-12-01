using ExerciseFive;
using Xunit;

namespace T2_PR2_xUnit_Test
{
    public class xUnitTest
    {
        [Fact]
        public void ClassifyAgeTest1()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = 0;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void ClassifyAgeTest2()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = 17;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void ClassifyAgeTest3()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = 18;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ClassifyAgeTest4()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = 65;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void ClassifyAgeTest5()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = 66;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void ClassifyAgeTest6()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = -1;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void ClassifyAgeTest7()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int age = 121;
            // Act
            var result = personalHelper.ClassifyAge(age);
            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void IsEvenTest1()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int number = 0;
            // Act
            var result = personalHelper.IsEven(number);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEvenTest2()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int number = 1;
            // Act
            var result = personalHelper.IsEven(number);
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEvenTest3()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            int number = 2;
            // Act
            var result = personalHelper.IsEven(number);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void NameAnalyserTest1()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            string name = "Anna";
            // Act
            var (IsShort, IsPalindrome) = personalHelper.NameAnalyser(name);
            // Assert
            Assert.True(IsShort);
            Assert.True(IsPalindrome);
        }

        [Fact]
        public void NameAnalyserTest2()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            string name = "Juan";
            // Act
            var (IsShort, IsPalindrome) = personalHelper.NameAnalyser(name);
            // Assert
            Assert.True(IsShort);
            Assert.False(IsPalindrome);
        }

        [Fact]
        public void NameAnalyserTest3()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            string name = "Radar";
            // Act
            var (IsShort, IsPalindrome) = personalHelper.NameAnalyser(name);
            // Assert
            Assert.False(IsShort);
            Assert.True(IsPalindrome);
        }

        [Fact]
        public void NameAnalyserTest4()
        {
            // Arrange
            var personalHelper = new PersonaHelper();
            string name = "House";
            // Act
            var (IsShort, IsPalindrome) = personalHelper.NameAnalyser(name);
            // Assert
            Assert.False(IsShort);
            Assert.False(IsPalindrome);
        }

        [Fact]
        public void VerifyColourTest1()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string colour = "blau";
            //Act
            var result = personalHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void VerifyColourTest2()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string colour = "verd";
            //Act
            var result = personalHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void VerifyColourTest3()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string colour = "negre";
            //Act
            var result = personalHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void VerifyColourTest4()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string colour = "";
            //Act
            var result = personalHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void PersonalityTest1()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string preference = "matí";
            //Act
            var result = personalHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void PersonalityTest2()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string preference = "nit";
            //Act
            var result = personalHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void PersonalityTest3()
        {
            //Arrange
            var personalHelper = new PersonaHelper();
            string preference = "tarda";
            //Act
            var result = personalHelper.PersonalityTest(preference);
            //Assert
            Assert.Equal(2, result);
        }

    }
}