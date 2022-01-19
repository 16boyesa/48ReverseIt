using System;                                                                               // https://live.withcode.uk/alevel/?id=48 
namespace _48ReverseIt { class Program {                                                    // Accept a string from the user, then reverse it, returning the result
        static void Main() {
            string text = Console.ReadLine();                                               // Accepts the string
            for (int i = text.Length - 1; i >= 0; i--) {                                    // cycles through string
                Console.Write(text.Substring(i, 1)); }                                      // outputs the characters in reverse order
            Console.Read(); } } }