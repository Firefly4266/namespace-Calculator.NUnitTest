using System;
using NUnit.Framework;

namespace Calculator.NUnitTest
{
    [TestFixture]
    public class CalculatorOpTest
    {
        //Here we make sut (System under test) globally available
        CalculatorOp sut;

        [OneTimeSetUp]
        //We create a new instance object in our set up method. We do this INSIDE the "OneTimeSetUp" attribute.

        public void TestSetUp()
        {
            sut = new CalculatorOp();
        }
        [Test]
        //Now the sut instance can be used without being instantiated in every test case.
        public void ShouldAddReturnNineWhenPassedFiveAndFour()
        {
            int result = sut.Add(5, 4);
            Assert.That(result, Is.EqualTo(9));
        }
        [Test]
        public void ShouldMulReturnTwentyWhenPassedFiveAndFour()
        {
            int result = sut.Mul(5, 4);
            Assert.That(result, Is.EqualTo(20));
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            sut = null;
        }
    }

}
