namespace MyUtilities
{
    public static class StringUtils
    {
        public static string ToUpper(string s)
        {
            String output = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    output += (char)(s[i] - 'a' + 'A');
                }
                else
                    output += s[i];
            }
            return output;
        }

        public static string ToLower(string s)
        {
            String output = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    output += (char)(s[i] - 'A' + 'a');
                }
                else
                    output += s[i];
            }
            return output;
        }

        public static int Length(string s)
        {
            int i = 0;
            foreach (char letter in s)
            {
                i++;
            }
            return i;
        }

        public static string Reverse(string s)
        {
            string reversestring = "";
            int length;

            length = s.Length - 1;

            while (length >= 0)
            {
                reversestring = reversestring + s[length];
                length--;
            }
            return reversestring;
        }

        public static int CountVowels(string s)
        {
            int vowel = 0;
            int cons = 0;
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {

                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel++;
                }
                else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    cons++;
                }
            }

            return vowel;
        }

        public static int CountConstants(string s)
        {
            int vowel = 0;
            int cons = 0;
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {

                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    vowel++;
                }
                else if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    cons++;
                }
            }

            return cons;
        }

        public static bool HasLetter(string s, string p)
        {
            int l = s.Length;
            int c = p.Length;
            int f = 0;
            for (int i = 0; i < l; i++)
            {
                if (s[i] == p[0])
                {
                    for (int K = i + 1, j = 1; j < c; j++, K++)
                    {
                        if (s[K] == p[j])
                        {
                            f++;
                        }
                    }
                }
            }
            if (f == c - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static char Mode(string s)
        {
            int[] charCount = new int[256];
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                charCount[s[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[s[i]])
                {
                    maxCount = charCount[s[i]];
                    character = s[i];
                }
            }
            return character;
        }
        public static int IndexOfLetter(string s)
        {
            int index = -1;
            int[] arrayValues = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                int value = s[i] - 'a';
                arrayValues[value] += 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                int value = s[i] - 'a';
                if (arrayValues[value] == 1)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static char[] SortInAlphabeticalOrder(string s)
        {
            char temp;
            string str = s.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            return charstr;
        }
    }
}

