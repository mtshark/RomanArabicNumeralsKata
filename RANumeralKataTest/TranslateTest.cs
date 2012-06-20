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
        ///A test for Translate Single Roman Character Translate I
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterRomanNumeralTest_I_1() {
            string INPUTARG = "I";
            string EXPECTED = "1";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test for Translate Single Roman Character Translate V
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterRomanNumeralTest_V_5() {
            string INPUTARG = "V";
            string EXPECTED = "5";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test for Translate Single Roman Character Translate X
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterRomanNumeralTest_X_10() {
            string INPUTARG = "X";
            string EXPECTED = "10";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        } /// <summary>
        ///A test to Translate from multiple Roman Character  2
        ///</summary>
        [TestMethod]
        public void TranslateMultipleRomanCharacterToArabicTest_II_2() {
            string INPUTARG = "II";
            string EXPECTED = "2";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate from multiple Roman Character 3
        ///</summary>
        [TestMethod]
        public void TranslateMultipleRomanCharacterToArabicTest_III_3() {
            string INPUTARG = "III";
            string EXPECTED = "3";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate from multiple Roman Character 7
        ///</summary>
        [TestMethod]
        public void TranslateMultipleRomanCharacterToArabicTest_VII_7() {
            string INPUTARG = "VII";
            string EXPECTED = "7";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate from multiple Roman Character 4
        ///</summary>
        [TestMethod]
        public void TranslateMultipleRomanCharacterToArabicTest_IV_4() {
            string INPUTARG = "IV";
            string EXPECTED = "4";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate from multiple Roman Character 14
        ///</summary>
        [TestMethod]
        public void TranslateMultipleRomanCharacterToArabicTest_XIV_14() {
            string INPUTARG = "XIV";
            string EXPECTED = "14";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate from multiple Roman Character 1944
        ///</summary>
        [TestMethod]
        public void TranslateMultipleRomanCharacterToArabicTest_MCMXLIV_1944() {
            string INPUTARG = "MCMXLIV";
            string EXPECTED = "1944";
            string ACTUAL = Translate.ToArabic(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        #endregion


        #region From Arabic
        /// <summary>
        ///A test to Translate To Single Roman Character  1
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterArabicNumeralTest_1_I() {
            string INPUTARG = "1";
            string EXPECTED = "I";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Single Roman Character  5
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterArabicNumeralTest_5_V() {
            string INPUTARG = "5";
            string EXPECTED = "V";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Single Roman Character  10
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterArabicNumeralTest_10_X() {
            string INPUTARG = "10";
            string EXPECTED = "X";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Single Roman Character  50
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterArabicNumeralTest_50_L() {
            string INPUTARG = "50";
            string EXPECTED = "L";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Single Roman Character  500
        ///</summary>
        [TestMethod]
        public void TranslateSingleCharacterArabicNumeralTest_500_D() {
            string INPUTARG = "500";
            string EXPECTED = "D";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  2
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_2_II() {
            string INPUTARG = "2";
            string EXPECTED = "II";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  3
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_3_III() {
            string INPUTARG = "3";
            string EXPECTED = "III";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  20
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_20_XX() {
            string INPUTARG = "20";
            string EXPECTED = "XX";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  200
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_200_II() {
            string INPUTARG = "200";
            string EXPECTED = "CC";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  2000
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_2000_MM() {
            string INPUTARG = "2000";
            string EXPECTED = "MM";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  2777
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_2777_MMDCCLXXVII() {
            string INPUTARG = "2777";
            string EXPECTED = "MMDCCLXXVII";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        /// <summary>
        ///A test to Translate To Multiple Roman Character  4
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_4_IV() {
            string INPUTARG = "4";
            string EXPECTED = "IV";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }

        /// <summary>
        ///A test to Translate To Multiple Roman Character 1944
        ///</summary>
        [TestMethod]
        public void TranslateMultipleCharacterArabicNumeralTest_1944_MCMXLIV() {
            string INPUTARG = "1944";
            string EXPECTED = "MCMXLIV";
            string ACTUAL = Translate.ToRoman(INPUTARG);
            Assert.AreEqual(EXPECTED, ACTUAL);
        }
        #endregion
       
    }
}
