using PatternEye.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using PatternEye.Common;

namespace PatternEyeTests
{
    
    
    /// <summary>
    ///This is a test class for RegionTest and is intended
    ///to contain all RegionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PRegionTest
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
        ///A test for Region Constructor
        ///</summary>
        [TestMethod()]
        public void RegionConstructorTest()
        {
            int width = 0; // TODO: Initialize to an appropriate value
            int height = 0; // TODO: Initialize to an appropriate value
            PRegion target = new PRegion(width, height);
            Assert.AreEqual(target.Pixels.Length, (width + 1) * (height + 1));
        }

        /// <summary>
        ///A test for sample
        ///</summary>
        [TestMethod()]
        public void sampleTest()
        {
            int width = 4; // TODO: Initialize to an appropriate value
            int height = 4; // TODO: Initialize to an appropriate value
            PRegion target = new PRegion(width, height); // TODO: Initialize to an appropriate value
            Color v = new RColor(1,10,100,200).toColor(); // TODO: Initialize to an appropriate value
            int c = 0; // TODO: Initialize to an appropriate value
            int r = 0; // TODO: Initialize to an appropriate value
            target.sample(v, c, r);
            Assert.AreEqual(target.Pixels[c, r].toColor(), v);
        }

        /// <summary>
        ///A test for sample
        ///</summary>
        [TestMethod()]
        public void sampleTest1()
        {
            int width = 0; // TODO: Initialize to an appropriate value
            int height = 0; // TODO: Initialize to an appropriate value
            PRegion target = new PRegion(width, height); // TODO: Initialize to an appropriate value
            RColor v = new RColor(); // TODO: Initialize to an appropriate value
            int c = 0; // TODO: Initialize to an appropriate value
            int r = 0; // TODO: Initialize to an appropriate value
            target.sample(v, c, r);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for sample
        ///</summary>
        [TestMethod()]
        public void sampleTest2()
        {
            int width = 0; // TODO: Initialize to an appropriate value
            int height = 0; // TODO: Initialize to an appropriate value
            PRegion target = new PRegion(width, height); // TODO: Initialize to an appropriate value
            int c = 0; // TODO: Initialize to an appropriate value
            int r = 0; // TODO: Initialize to an appropriate value
            RColor expected = new RColor(); // TODO: Initialize to an appropriate value
            RColor actual;
            actual = target.sample(c, r);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Pixels
        ///</summary>
        [TestMethod()]
        public void PixelsTest()
        {
            int width = 0; // TODO: Initialize to an appropriate value
            int height = 0; // TODO: Initialize to an appropriate value
            PRegion target = new PRegion(width, height); // TODO: Initialize to an appropriate value
            RColor[,] expected = null; // TODO: Initialize to an appropriate value
            RColor[,] actual;
            target.Pixels = expected;
            actual = target.Pixels;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
