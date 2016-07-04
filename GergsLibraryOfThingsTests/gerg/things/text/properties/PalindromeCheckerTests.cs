using Microsoft.VisualStudio.TestTools.UnitTesting;
using gerg.things.text.properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerg.things.text.properties.Tests
{
    [TestClass()]
    public class PalindromeCheckerTests
    {
        [TestMethod()]
        public void IsPalindrome_IsPalindrome_Test()
        {
            //Arrange
            string str = "racecar";
            //Act
            bool result = PalindromeChecker.IsPalindrome(str);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void IsPalindrome_IsNotPalindrome_Test() {
            //Arrange
            string str = "gerg";
            //Act
            bool result = PalindromeChecker.IsPalindrome(str);
            //Assert
            Assert.IsFalse(result);
        }
    }
}