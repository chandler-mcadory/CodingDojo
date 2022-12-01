namespace practice
{
    public static class Functions
    {        
        public static bool Pallys(string word)
        {
            int c = word.Length / 2;
            if (word.Length % 2 == 0)
            {
                c--;
            }

            for (int i = 0; i < word.Length; i++)
            {
                char a = word[i];
                char b = word[word.Length-i-1];

                if (a != b)
                {
                    return false;
                }
                if (i >= c)
                {
                    break;
                }
            }
            return true;
        }
    }
}