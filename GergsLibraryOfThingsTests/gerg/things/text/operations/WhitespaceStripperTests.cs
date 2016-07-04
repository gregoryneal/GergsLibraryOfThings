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
    public class WhitespaceStripperTests
    {
        [TestMethod()]
        public void StripWhitespace_NoWhitespace_Test()
        {
            //Arrange
            string original = "gerg.233";
            string expected = "gerg.233";
            //Act
            string result = WhitespaceStripper.StripWhitespace(original);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void StripWhitespace_WhitespaceOnFrontAndBack_Test() {
            //Arrange
            string original = "  gerg.2ee33#$       ";
            string expected = "gerg.2ee33#$";
            //Act
            string result = WhitespaceStripper.StripWhitespace(original);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void StripWhitespace_AmpersandOnFrontAndBack_Test() {
            //Arrange
            string original = "&&&&gergTESTSah0y$%($&&*&";
            string expected = "gergTESTSah0y$%($&&*";
            //Act
            string result = WhitespaceStripper.StripWhitespace(original, '&');
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}