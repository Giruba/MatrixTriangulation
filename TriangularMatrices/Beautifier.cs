using System;
using System.Collections.Generic;
using System.Text;

namespace TriangularMatrices
{
    static class Beautifier
    {
        public static void TwoNewLines() {
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void UnderlineHeading(string text) {
            Console.WriteLine(text + "!");
            Console.WriteLine("----------------------------------");
        }

        public static void OneLine(string text) {
            Console.WriteLine(text);
        }

    }
}
