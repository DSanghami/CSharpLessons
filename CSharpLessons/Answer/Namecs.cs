using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class FindString
    {
public bool IsNameValid(string inputName)
    {
        bool hasNonAlphabetic = false;

        foreach (char c in inputName)
        {
            // Check if the ASCII value falls within the range of alphabetic characters
            int asciiValue = (int)c;
            if ((asciiValue < 65 || (asciiValue > 90 && asciiValue < 97) || asciiValue > 122))
            {
                hasNonAlphabetic = true;
                break; // If any character is not alphabetic, break the loop
            }
        }

        // Check if the length is at least 8 characters and there are no non-alphabetic characters
        return inputName.Length >= 8 && !hasNonAlphabetic;
    }
}
     class Test
    {
        String strFriends = "Tom and Jerry are good friends";
        FindString obj = new FindString();
        bool isValid = obj.IsNameValid(strFriends);

         if (isValid)
{
    Console.WriteLine("The name is valid.");
}
else
{
    Console.WriteLine("The name is not valid.");
}

    }
}
