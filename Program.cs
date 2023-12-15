using System;
using System.Collections.Generic;

namespace TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                start();
            }
        }

        private static void start()
        {
            Console.Clear();
            switch (AskInt("Do you want to:\n1. Rotate text\n2. Change word"))
            {
                case 1:
                    var rotateText = RotateText(Ask("Hva vil du rotere?"));
                    Console.WriteLine(rotateText);
                    break;
                case 2:
                    var changeWord = ChangeWord(Ask("Hva vil du endre?"));
                    Console.WriteLine(changeWord);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
            Console.ReadLine();
        }

        private static string RotateText(string question)
        {
            string text = null;
            for (int i = question.Length; i > 0; i--)
            {
                text += question[i - 1];
            }
            return text;
        }

        private static string ChangeWord(string question)
        {
            string text = null;
            foreach (var character in question)
            {
                if (character == 'e') text += 'a';
                else text += character;
            }
            return text;
        }

        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
    }
}
