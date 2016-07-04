using Microsoft.VisualStudio.TestTools.UnitTesting;
using GergsLibraryOfThings.gerg.things.text.operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerg.things.text.operations.Tests
{
    [TestClass()]
    public class StringReverserTests
    {
        [TestMethod()]
        public void ReverseString_EmptyString_Test()
        {
            //Arrange
            string original = "";            
            string expected = "";            
            //Act
            string reversed = StringReverser.ReverseString(original);
            
            //Assert
            Assert.AreEqual(expected, reversed, false);
        }

        [TestMethod()]
        public void ReverseString_MultiCharacter_Test() {
            //Arrange
            string original = "original";
            string expected = "lanigiro";
            //Act
            string reversed = StringReverser.ReverseString(original);
            //Assert
            Assert.AreEqual(expected, reversed, false);
        }

        [TestMethod()]
        public void ReverseString_SingleCharacter_Test() {
            //Arrange
            string original = "a";
            string expected = "a";
            //Act
            string reversed = StringReverser.ReverseString(original);
            //Assert
            Assert.AreEqual(expected, reversed, false);
        }

        [TestMethod()]
        public void ReverseString_MultiCharacter_MultiCase_Test() {
            //Arrange
            string original = "OrIgiNAL";
            string expected = "LANigIrO";
            //Act
            string reversed = StringReverser.ReverseString(original);
            //Assert
            Assert.AreEqual(expected, reversed, false);
        }
    }
}