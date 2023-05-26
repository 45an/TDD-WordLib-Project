namespace WordLib;
public class Worder
{
    public string IsPalindromeWordChecker(string inputWord)
    {


        if (string.IsNullOrEmpty(inputWord))
        {
            throw new ArgumentException("Input string cannot be empty.");
        }

        string inputString, reverseString = string.Empty;
        inputString = inputWord;


        /* Loop through the input word in reverse and build the backwards string
         * which is "radar" backwards"
         */

        for (int i = inputWord.Length - 1; i >= 0; i--)
        {
            reverseString += inputWord[i];
        }

        return reverseString;

        


    }


}