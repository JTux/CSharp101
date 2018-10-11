using System;
using _04_Encapsulation_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Encapsulation_2_Unit_Tests
{
    [TestClass]
    public class Room_Unit_Tests
    {
        private Room _room;

        [TestInitialize]
        public void Arrange()
        {
            _room = new Room(6, 8, 10);
        }

        [TestMethod]
        public void _8_CalculateLateralSurfaceArea_ReturnsDouble()
        {
            //-- Act
            var actual = _room.CalculateLateralSurfaceArea();

            var expected = 280;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        //TODO: Test exceptions, Square Footage

        [DataTestMethod]
        [DataRow(6, 8, 10)]
        [DataRow(15, 15, 11)]
        [DataRow(30, 30, 12)]
        public void _8_ConstructorWorksWithMultipleParams(double l, double w, double h)
        {
            //Act
            Room room = new Room(l, w, h);
            Console.WriteLine(room);
        }

        [DataTestMethod]
        [ExpectedException(typeof(ArgumentException), "The length should be between 6 and 30.")]
        [DataRow(5, 5, 11)]
        [DataRow(31, 31, 13)]
        public void _9_ConstructorThrowsException(double l, double w, double h)
        {
            //Act
            Room room = new Room(l, w, h);
        }
    }
}
