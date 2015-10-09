using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyTests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestResult()
        {
            //Arrange
            //sut standard = system under test
            Auction sut = new Auction();
            int i1 = 10;
            int i2 = 5;

            //Act
            sut.add(i1, i2);

            //Assert
            Assert.AreEqual(15, sut.result);
        }

        [TestMethod]
        public void Test_If_Number_Is_Bigger()
        {
            //Arrange
            TestClass2 sut = new TestClass2();
            int number1 = 8;
            int number2 = 5;

            //Act
            sut.bigger(number1, number2);

            //Assert
            Assert.IsTrue(sut.result);
        }
    }
}
