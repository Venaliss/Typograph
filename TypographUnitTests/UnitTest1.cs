using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Typograph;

namespace TypographUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Commands cmd = new Commands();
        [TestMethod]
        public void testReplacePlusMinus()
        {
            string text = "(+,-)";
            string expected = "±";

            string actual = cmd.replacePlusMinusSymbol(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testReplaceDefisNumberRange()
        {
            string text = "1-2";
            string expected = "1—2";

            string actual = cmd.replaceDefisNumberRange(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testRemoveExpessiveSpaces()
        {
            string text = "Hello?   How         kdk      are   you  ";
            string expected = "Hello? How kdk are you ";

            string actual = cmd.removeExcessiveSpaces(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testSpaceBeforeDash()
        {
            string text = "Я тебе сказал-что я не доволен твоим поведением";
            string expected = "Я тебе сказал -что я не доволен твоим поведением";

            string actual = cmd.nonSpaceBeforeDash(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testPunctuationFix()
        {
            string text = "Я тебе?сказал - что?я не доволен.твоим поведением";
            string expected = "Я тебе ? сказал - что ? я не доволен . твоим поведением";

            string actual = cmd.punctuationsFix(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testMyRule1()
        {
            string text = "Hello.how are you";
            string expected = "Hello.How are you";

            string actual = cmd.myRuleCapitalLetter(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testMyRule2()
        {
            string text = "...";
            string expected = "…";

            string actual = cmd.myRuleReplaceEllipsis(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void testAbsurdRule()
        {
            string text = "hello-hello";
            string expected = "hello-hello";

            string actual = cmd.myAbsurdRule(text);

            Assert.AreEqual(expected, actual);
        }
    }
}
