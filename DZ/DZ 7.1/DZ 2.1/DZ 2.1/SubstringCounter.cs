namespace DZ_2_1
{
    public class SubstringCounter
    {
        public static int CountOccurrences(string s, string s1)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(s1) || s1.Length > s.Length)
            {
                return 0;
            }

            char[] sArray = s.ToCharArray();
            char[] s1Array = s1.ToCharArray();
            int count = 0;

            for (int i = 0; i <= sArray.Length - s1Array.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < s1Array.Length; j++)
                {
                    if (sArray[i + j] != s1Array[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
