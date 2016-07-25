using System;
using System.Collections.Generic;

namespace GergsLibraryOfThings.gerg.things.text.operations
{
    public static class TextStripper {

        public static List<char> ValidEnglishPunctuation = new List<char> {'.', '?', '!', ',', ';', ':', '-', '(', ')', '[', ']', '{', '}', '\'', '"'};

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
        
        public static string StripAllPunctuation(string str) {
            char[] chars = str.ToCharArray();

            int first = 0;
            int last = chars.Length - 1;

            while (ValidEnglishPunctuation.Contains(chars[first])) {
                if (first >= last) {
                    return "";
                }

                first++;
            }

            while (ValidEnglishPunctuation.Contains(chars[last])) {
                if (last <= first) {
                    return "";
                }

                last--;
            }    

            return str.Substring(first, last - first + 1);
        }    
    }
}
