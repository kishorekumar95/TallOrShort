using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TallOrShort_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FindTall()
        {
            //Arrange
            int expected = 3;
            var heightArray = new List<double> { 5, 3.8, -4.5, -2.5, 2.4, 7.4, 6.8, 6.01, 5.9 };
            //Act
            int actual = TallOrShort.Program.FindTall(heightArray);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_FindShort()
        {
            //Arrange
            int expected = 2;
            var heightArray = new List<double> { 2.9, -3, 3.001, 5, 7, -2.9, 4.5, 6.1, 2.5 };
            //Act
            int actual = TallOrShort.Program.FindTall(heightArray);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
