using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestOefeningUnitTest
{
    [TestClass]
    public class MathLogicTest
    {
        [TestMethod]
        public void TestSomWaarden()
        {
            //PREPARE
            Double a = 542;
            Double b = 8;
            Double Expected = 550;
            Double Returned = 0;

            //EXECUTE
            OefeningUnitTest.MathLogic ml = new OefeningUnitTest.MathLogic();
            Returned = ml.Som(a, b);

            //ASSERT
            Assert.AreEqual(Expected, Returned);
        }

        [TestMethod]
        public void TestDelenDoorNul()
        {
            //PREPARE
            Double a = 500;
            Double b = 0;
            //Single Expected = 0;
            //Single Returned = 0;

            //EXECUTE
            OefeningUnitTest.MathLogic ml = new OefeningUnitTest.MathLogic();
            //Returned = ml.Delen(a, b);

            //ASSERT
            Assert.ThrowsException<DivideByZeroException>(() => ml.Delen(a,b));
        }

        [TestMethod]
        public void TestProductWaarden()
        {
            //PREPARE
            Double a = 5;
            Double b = 10;
            Double Expected = 50;
            Double Returned = 0;

            //EXECUTE
            OefeningUnitTest.MathLogic ml = new OefeningUnitTest.MathLogic();
            Returned = ml.Product(a, b);

            //ASSERT
            Assert.AreEqual(Expected, Returned);
        }

        [TestMethod]
        public void TestDelenWaarden()
        {
            //PREPARE
            Double a = 5;
            Double b = 2;
            Double Expected = 2.5;
            Double Returned = 0;

            //EXECUTE
            OefeningUnitTest.MathLogic ml = new OefeningUnitTest.MathLogic();
            Returned = ml.Delen(a, b);

            //ASSERT
            Assert.AreEqual(Expected, Returned);
        }
    }
}