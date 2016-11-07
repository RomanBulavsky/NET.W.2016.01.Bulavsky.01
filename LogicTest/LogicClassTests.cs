using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{
    [TestClass]
    public class LogicClassTests
    {
        [TestMethod]
        public void findMethos_ReturnedInts()
        {
            int[] mas = { 1, 2, 3, 4 };
           
            int actInt = Logic.BinarySearch.find(mas, 3);
            int actInt2 = Logic.BinarySearch.find(mas, 5);

            Assert.AreEqual(2, actInt);
            Assert.AreEqual(-1, actInt2);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void findMethos_ReturnedException()
        {
            Logic.BinarySearch.find(null, 3);
            
        }
    }
}
