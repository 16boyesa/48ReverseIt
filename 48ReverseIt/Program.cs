using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48ReverseIt
{
    class Program
    {
        static void Main() { 
        string text = "12345", a, b;
            for (int i = 0; i < (text.Length+1) / 2; i ++) { 
                a = text.Substring(i, 1);
                b = text.Substring(text.Length - i, 1);
                text.Substring(i, 1);
            }
        }
    }
}


// https://live.withcode.uk/alevel/?id=48
// 48 - Reverse It

// Have the programme allow a user to enter some text and then the programme will reverse it and print it back to the screen.