using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacoCat.Models
{
    //This is a View Model - it helps my Views not my Database
    public class Palindrome
    {
        //The word the user input
        public string InputWord { get; set; }

        //That word reversed
        public string RevWord { get; set; }

        //Is it a palindrome
        public bool IsPalindrome { get; set; }

        //What do I output?
        public string Message { get; set; }

    }
}
