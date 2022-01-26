namespace SwapVowels
{
    public class Swap
    {
        public char SwapVowel(char character)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == character)
                {
                    if (i == vowels.Length - 1) return vowels[0];
                    return vowels[i + 1];
                }
            }

            return character;
        }
    }
}