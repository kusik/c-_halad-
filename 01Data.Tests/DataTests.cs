using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01Data.Model;
using System.Linq;

namespace _01Data.Tests
{
    /// <summary>
    /// Summary description for DataTests
    /// </summary>
    [TestClass]
    public class DataTests
    {
        public DataTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void DataTests_Categories_CountShouldBeEqualTo3()
        {
            //Act
            var db = new DataContext();

            //Arrange
            var count = db.Categories.Count();

            // Asset
            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public void DataTests_Categories_AfterAddCategoryCountShouldBe3()
        {
            //Act
            
            using (var db = new DataContext())
            {
                //Arrange
                var cat=db.Categories.Add(new Category() { Name = "Múszaki cikkek" });
                // mentés az adatbázisba
                db.SaveChanges();

                var count = db.Categories.Count();
                // Asset

                try
                {
                    Assert.AreEqual(4, count);
                }
                finally
                {
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                }
                
                
            }
   
            
        }
    }
}
