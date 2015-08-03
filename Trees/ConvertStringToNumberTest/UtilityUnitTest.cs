using ConvertStringToNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumberTest
{
    [TestClass]
    public class UtilityUnitTest
    {
        
        
        [TestMethod]
        public void StringToLongAlphaTest1()
        {
            long result = Utility.StringToLong("1a23");

            long expected = -1;

            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void StringToLongAlphaTest2()
        {
            long result = Utility.StringToLongAdvance("1a23");

            long expected = 0;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void StringToLongTest1()
        {
            long result = Utility.StringToLong("123");

            long expected = 123;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void StringToLongTest2()
        {
            long result = Utility.StringToLong("0123");

            long expected = 123;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void StringToLongTest3()
        {
            long result = Utility.StringToLong("0123456789");

            long expected = 123456789;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void StringToLongTestAdvance4()
        {
            long result = Utility.StringToLongAdvance("2,147,483,648,214,748,364 ");

            long expected = 2147483648214748364 ;

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void StringToLongNegetiveNumberTest5()
        {
            long result = Utility.StringToLongAdvance("-2,147,483,648,214,748,364 ");

            long expected = -2147483648214748364;

            Assert.AreEqual(expected, result);

        }
    }
}
