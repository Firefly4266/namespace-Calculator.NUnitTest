using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorOpTest
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassedFiveAndFour()
        {
            ///create new instance of object who's method is being tested
            CalculatorOp sut = new CalculatorOp();
            ///Test method and set result to a variable
            int result = sut.Add(5, 4);
            ///Check to see if expected result is equal to the variable that we set
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void ShouldMulReturnTwentyWhenPassedFiveAndFour()
        {
            CalculatorOp sut = new CalculatorOp();
            int result = sut.Mul(5, 4);
            Assert.AreEqual(20, result);
        }
    }
}
