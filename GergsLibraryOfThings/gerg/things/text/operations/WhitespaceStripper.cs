using System;
using System.Collections.Generic;

namespace GergsLibraryOfThings.gerg.things.text.operations
{
    public static class WhitespaceStripper {
        public static string StripWhitespace(string str, char characterToTrim = ' ') {
            List<char> temp = new List<char>();
            int firstIndex;
            int lastIndex;
            int i = 0;
            while(Char.Equals(str[i], characterToTrim)) {
                i++;
            }
            firstIndex = i;
            i = str.Length - 1;
            while(Char.Equals(str[i], characterToTrim)) {
                i--;
            }
            lastIndex = i;
            for(i = firstIndex; i <= lastIndex; i++) {
                temp.Add(str[i]);
            }
            return new string(temp.ToArray());
        }        
    }
}
