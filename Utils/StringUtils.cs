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

        public static string CountVowels(string s)
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

            return "Vowels - " + vowel + ".";
        }

        public static string CountConstants(string s)
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

            return "Constants - " + cons + ".";
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
    }
}

