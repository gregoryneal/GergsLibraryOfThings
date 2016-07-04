using System;

namespace gerg.things.text.operations {
    public static class StringReverser
    {
        public static string ReverseString(string str) {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
