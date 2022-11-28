using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace UnitTests
{
    [TestClass]
    public class StringUtilitiesTests
    {
        //Call method from string
        [TestMethod]
        public void UniqueChar1()
        {
            string s = "abcd";
            Assert.IsTrue(s.IsUniqueCharacterSet());
        }

        //Call method from class
        [TestMethod]
        public void UniqueChar2()
        {
            string s = "abcd";
            Assert.IsTrue(StringUtilities.StringUtilities.IsUniqueCharacterSet(s));
        }

        //Call method from string
        [TestMethod]
        public void UniqueChar3()
        {
            string s = "abcddcba";
            Assert.IsFalse(s.IsUniqueCharacterSet());
        }

        //Call method from string
        [TestMethod]
        public void UniqueChar4()
        {
            string s = "1234567890 --";
            Assert.IsFalse(s.IsUniqueCharacterSet());
        }

        //Call method from string
        [TestMethod]
        public void UniqueChar5()
        {
            string s = "abcdDCBA";
            Assert.IsFalse(s.IsUniqueCharacterSet());
        }

        //Call method from string
        [TestMethod]
        public void UniqueChar6()
        {
            string s = "abcdefghijklmnopqrstuvwxyz";
            Assert.IsTrue(s.IsUniqueCharacterSet());
        }

        //Call method from string
        [TestMethod]
        public void UniqueChar7()
        {
            string s = "aA";
            Assert.IsFalse(s.IsUniqueCharacterSet());
        }

        //Call method from class
        [TestMethod]
        public void UniqueChar8()
        {
            string s = "";
            Assert.IsTrue(s.IsUniqueCharacterSet());
        }

        //Call method from string
        [TestMethod]
        public void UniqueChar9()
        {
            string s = "a";
            Assert.IsTrue(s.IsUniqueCharacterSet());
        }

        //Call method from class
        [TestMethod]
        public void UniqueChar10()
        {
            string s = " ";
            Assert.IsTrue(s.IsUniqueCharacterSet());
        }

    }
}
