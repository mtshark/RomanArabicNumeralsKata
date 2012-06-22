using RomanArabicNumeralsKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RANumeralKataTest
{
    
    
    /// <summary>
    ///This is a test class for TranslateTest and is intended
    ///to contain all TranslateTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TranslateTest {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        /// <summary>
        ///A test for Translate IsArabicNumeral
        ///</summary>
        [TestMethod]
        public void TakeUserInputAndCheckIsArabicTrue() {
            string INPUTARG = "12";
            bool EXPECTED = true;
            bool ACTUAL = Translate.IsArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);

        }
        /// <summary>
        ///A test for Translate IsArabicNumeral
        ///</summary>
        [TestMethod]
        public void TakeUserInputAndCheckIsArabicFalse() {
            string INPUTARG = "IV";
            bool EXPECTED = false;
            bool ACTUAL = Translate.IsArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }

        #region From Roman
        /// <summary>
        ///A test for Translate Roman Characters
        ///</summary>
        [
        DeploymentItem("RANumeralKataTest\\numbers.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential), TestMethod()]
        public void TranslateRomanNumeralsTest() {
            string INPUTARG = TestContext.DataRow["Roman"] as string;
            string EXPECTED = TestContext.DataRow["Arabic"].ToString();
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        
        #endregion


        #region From Arabic
        /// <summary>
        ///A test for Translate Arabic Characters
        ///</summary>
        [DeploymentItem("RANumeralKataTest\\numbers.csv"), DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\numbers.csv", "numbers#csv", DataAccessMethod.Sequential), TestMethod()]
        public void TranslateArabicNumeralTest() {
            string INPUTARG = TestContext.DataRow["Arabic"].ToString();
            string EXPECTED = TestContext.DataRow["Roman"] as string;
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }

        #endregion
       
    }
}
