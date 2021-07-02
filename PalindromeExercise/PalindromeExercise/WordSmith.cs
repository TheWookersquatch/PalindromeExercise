using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }

        public WordSmith(string word)
        {
            Word = word;
        }

        public string Word { get; set; }
    
        public bool IsAPalindrome(string input)
        {
            var noSpaces = input.Replace(" ", "");
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var  reverseInput = new string(charArray);
            var noSpacesArrayy = noSpaces.ToCharArray();
            Array.Reverse(noSpacesArrayy);
            var reverseNoSpaces = new string(noSpacesArrayy);


            if (input == reverseInput)
            {
                return true;
            }
            else if (noSpaces == reverseNoSpaces)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //In your WordSmith class create a method called IsAPalindrome:
        //The method’s return type is bool
           // The method has 1 parameter of type string
          //  Add the logic to test whether the input string is a palindrome
    }
}
