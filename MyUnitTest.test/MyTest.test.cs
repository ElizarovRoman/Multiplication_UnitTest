using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTest.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void multiplication_5and24_120ret()
        {
            //arrange
            int x = 5;
            int y = 24;
            int expected = 120;
            //act
            MyTest t = new MyTest();
            int actual = t.multiplication(x, y);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
