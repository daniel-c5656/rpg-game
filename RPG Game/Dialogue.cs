using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Dialogue
    {
        private static string[] dialogue =
        {
            "Line 1",
            "Line 2",
            "Line 3",
            "COMBAT",
            "Line 4"
        };
        private static int currentLine = 0;

        private static string border = "========================================================================================";
        private static void Print(string line)
        {
            line = TextWrap(line);
            foreach (char i in line)
            {
                Console.Write(i);
                Thread.Sleep(25);
            }
        }
        public static void Show()
        {
            while (true)
            {
                if (dialogue[currentLine] == "COMBAT")
                {
                    currentLine++; // Continue story after combat finished
                    // Activate combat sequence somehow
                    break;
                }

                Console.WriteLine(border + '\n');
                Print(dialogue[currentLine]);
                currentLine++;
                Console.WriteLine("\n\n" + border);
                Console.Write(">");
                Console.ReadLine();
                Console.Clear();
            }

        }
        private static string TextWrap(string line)
        {
            // Wraps lines so that they are the same length as the border.
            for (int i = border.Length; i < line.Length; i += border.Length)
            {
                line = line.Insert(i, "\n");
            }
            return line;
        }
    }
}
