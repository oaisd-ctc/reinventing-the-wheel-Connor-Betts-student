namespace MyUtilities
{
    public static class StringUtils
    {

        /// <summary>
        /// Turns letters to uppercase
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// Uppercase verion of string 
        /// </returns>
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

        /// <summary>
        /// Turns letters to lowercase
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// lowercase version of string
        /// </returns>
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

        /// <summary>
        /// Counts the amount of characters in a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The number of characters in the string
        /// </returns>
        public static int Length(string s)
        {
            int i = 0;
            foreach (char letter in s)
            {
                i++;
            }
            return i;
        }

        /// <summary>
        /// Reverses the given string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The reversed version of a string....Example....Input(hello)-Output(olleh)
        /// </returns>
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

        /// <summary>
        /// Counts the amount of Vowels in a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The number of vowels in the string
        /// </returns>

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

        /// <summary>
        /// Counts the amount of constants in a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The number of constants in the string
        /// </returns>
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

        /// <summary>
        /// Checks to see if a string contains a certain letter or word
        /// </summary>
        /// <param name="s">The first string.</param>
        /// <param name="p">The second string.</param>
        /// <returns>
        /// True if it does contain the string, False if it does not contain the string
        /// </returns>
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

        /// <summary>
        /// Finds the letter in a string that repeats the most
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The letter that is repeated the most
        /// </returns>
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

        /// <summary>
        /// Finds where a letter is located in a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The position of the letter in the string
        /// </returns>
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

        /// <summary>
        /// Sorts the letters of a string in alphabetical order
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The string in alphabetical order
        /// </returns>

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

        /// <summary>
        /// Finds the vowels in a string
        /// </summary>
        /// <param name="s">The string.</param>
        /// <returns>
        /// The vowels found in the string
        /// </returns>

        public static void Vowel(string str)
        {
            int[] Vowels = { 65, 97, 69, 101, 73, 105, 79, 111, 85, 117 };
            foreach (char s in str)
            {
                if (ArrayUtils.HasNumber(Vowels, (int)s))
                {
                    Console.Write(s + " ");
                }
            }
        }
    }
}

