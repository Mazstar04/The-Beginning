namespace EncodeString
{
    public class Encode
    {
 
        public string EncodeString(string firstPart, string secondPart)
        {
            char[] encondedFirstPart = firstPart.ToCharArray();
            char[] encodedSecondPart = secondPart.ToCharArray();

            //converting the string to an array of character. Replacing the characters in the string directly will cause a chain reaction getting the character replaced everywhere in the string

            for (int i = 1; i < firstPart.Length; i += 2) //looping through the odd index only
            {
                encodedSecondPart[i - 1] = firstPart[i]; // replacing the even part of the second half of the string with the odd part of the first half
                encondedFirstPart[i] = secondPart[i - 1]; // replacing the odd part of the first half of the string with the even part of the second half
            }

            return $"{new string(encondedFirstPart)}{new string(encodedSecondPart)}"; //return a concatenation of the encoded halves
        }
    }
}