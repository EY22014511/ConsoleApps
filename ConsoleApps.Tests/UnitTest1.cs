using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace ConsoleApps.Tests
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();
            
            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.InputDistance = 1.0;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 5280;
            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }
        [TestMethod]
        public void TestFeetToMiles()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.MILES;

            converter.InputDistance = 5280;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1;
            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }
        [TestMethod]
        public void TestMetresToFeet()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.FEET;

            converter.InputDistance = 1.0;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 3.28084;
            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }
        [TestMethod]
        public void TestFeetToMetres()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.FEET;
            converter.ToUnit = DistanceConverter.METRES;

            converter.InputDistance = 3.28084;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1;
            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.METRES;
            converter.ToUnit = DistanceConverter.MILES;

            converter.InputDistance = 1609.34;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 1;
            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            //Arrange
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.METRES;

            converter.InputDistance = 2.0;

            //Act
            converter.CalculateDistance();

            double expectedDistance = 3218.68;
            //Assert
            Assert.AreEqual(expectedDistance, converter.OutputDistance);
        }
    }
}
