// File: UnitTest1.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApp; // Make sure this is the correct namespace of your Program class

namespace MyApp.Tests // Ensure the namespace here matches your test project's structure
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumMethod()
        {
            int expected = 8;
            int actual = ;
            Assert.AreEqual(expected, actual);
        }
    }
}
