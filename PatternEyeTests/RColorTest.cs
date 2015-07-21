using PatternEye.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace PatternEyeTests
{
    
    
    /// <summary>
    ///This is a test class for RColorTest and is intended
    ///to contain all RColorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RColorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RColor Constructor
        ///</summary>
        [TestMethod()]
        public void RColorConstructorTest()
        {
            byte r = 0; // TODO: Initialize to an appropriate value
            byte g = 0; // TODO: Initialize to an appropriate value
            byte b = 0; // TODO: Initialize to an appropriate value
            byte a = 0; // TODO: Initialize to an appropriate value
            RColor target = new RColor(r, g, b, a);
            Assert.AreEqual(r, target.red);
            Assert.AreEqual(g, target.green);
            Assert.AreEqual(b, target.blue);
            Assert.AreEqual(a, target.alpha);
        }

        /// <summary>
        ///A test for fromColor
        ///</summary>
        [TestMethod()]
        public void fromColorTest()
        {
            Color c = Color.Red; // TODO: Initialize to an appropriate value
            RColor expected = new RColor(255,0,0,255); // TODO: Initialize to an appropriate value
            RColor actual;
            actual = RColor.fromColor(c);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for toColor
        ///</summary>
        [TestMethod()]
        public void toColorTest()
        {
            RColor target = new RColor(0,128,0,255); // TODO: Initialize to an appropriate value
            Color expected = Color.FromArgb(0,128,0,255); // TODO: Initialize to an appropriate value
            Color actual;
            actual = target.toColor();
            Assert.AreEqual(expected, actual);
        }
    }
}
