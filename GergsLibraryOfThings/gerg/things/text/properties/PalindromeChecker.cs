using System;
using gerg.things.text.operations;

namespace gerg.things.text.properties {
    public static class PalindromeChecker
    {
        public static bool IsPalindrome(string str) {
            string reversed = StringReverser.ReverseString(str);
            return String.Equals(reversed, str);
        } 
    }
}