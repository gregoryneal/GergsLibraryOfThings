using Microsoft.VisualStudio.TestTools.UnitTesting;
using GergsLibraryOfThings.gerg.things.text.operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GergsLibraryOfThings.gerg.things.text.operations.Tests
{
    [TestClass()]
    public class TextStripperTests
    {
        [TestMethod()]
        public void StripWhitespaceNoWhitespaceTest()
        {
            //Arrange
            string original = "gerg.233";
            string expected = "gerg.233";
            //Act
            string result = TextStripper.StripWhitespace(original);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void StripWhitespaceWhitespaceOnFrontAndBackTest() {
            //Arrange
            string original = "  gerg.2ee33#$       ";
            string expected = "gerg.2ee33#$";
            //Act
            string result = TextStripper.StripWhitespace(original);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void StripWhitespaceAmpersandOnFrontAndBackTest() {
            //Arrange
            string original = "&&&&gergTESTSah0y$%($&&*&";
            string expected = "gergTESTSah0y$%($&&*";
            //Act
            string result = TextStripper.StripWhitespace(original, '&');
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void StripPunctuationOnBothSidesTest() {
            //Arrange
            string original = ".!?Gergaroyskins?!.";
            string expected = "Gergaroyskins";

            //Act
            string actual = TextStripper.StripAllPunctuation(original);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}