using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PigLatinTransletor;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_ToPigLatin()
        {
            Translator traslator = new Translator();

            string actual = traslator.ToPigLatin("button");            
            string expected = "uttonbay";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_ToPigLatin2()
        {
            Translator traslator = new Translator();

            string actual = traslator.ToPigLatin("sour");
            string expected = "oursay ";
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod_ToPigLatin3()
        {
            Translator traslator = new Translator();

            string actual = traslator.ToPigLatin("developing");
            string expected = "evelopingday";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod_ToPigLatin4()
        {
            Translator traslator = new Translator();

            string actual = traslator.ToPigLatin("a");
            string expected = "aay";
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethod_isStartInVowels()
        {
            Translator traslator = new Translator();

            bool actual = traslator.isStartInVowels("awesome");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void TestMethod_isStartInConsonant()
        {
            Translator traslator = new Translator();

            bool actual = traslator.isStartInConsonant("laptop");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod_GetCountConsonantLeters()
        {
            Translator traslator = new Translator();

            int actual = traslator.GetCountConsonantLeters("three");
            int expected = 3;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethod_GetCountConsonantLeters2()
        {
            Translator traslator = new Translator();

            int actual = traslator.GetCountConsonantLeters("yalantis");
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }
    }
}
