using System;  // https://live.withcode.uk/alevel/?id=48
namespace _48ReverseIt { class Program {
        static void Main() {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++) {
                Console.Write(text.Substring(text.Length - (i + 1), 1)); }
            Console.Read(); } } }