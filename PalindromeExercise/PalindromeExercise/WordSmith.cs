using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string palin)
        {
            if (string.IsNullOrEmpty(palin)) return false;
            var charPalin = palin.ToCharArray();
            Array.Reverse(charPalin);
           var newPalin =  new string(charPalin);
            return newPalin.ToLower().Replace(" ", "") == palin.ToLower().Replace(" ", "");
            
        }
    }
}
