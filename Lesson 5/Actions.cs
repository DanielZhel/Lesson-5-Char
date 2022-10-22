using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_5
{
    public class Actions
    {
        public static string Menu(ref string menu)
        {
            Console.WriteLine("Choose on of the action:");
            Console.WriteLine("1.Find words containing the maximum number of digits.");
            Console.WriteLine("2.Find the longest word and determine how many times it occurs in the text.");
            Console.WriteLine("3.Replace the numbers from 0 to 9 with the words 'zero', one', ..., 'nine'.");
            Console.WriteLine("4.Display first interrogative and then exclamatory sentences.");
            Console.WriteLine("5.Display only sentences that do not contain commas.");
            Console.WriteLine("6.Find words that start and end with the same letter.");
            menu = Console.ReadLine();
            return menu;
        }
        public static void MaxNumber(string[] text)
        {
            int Max = 0;
            int Index = 0;
            for (int word = 0; word < text.Length; word++)
            {

                int temp = 0;
                for (int sym = 0; sym < text[word].Length; sym++)
                {
                    if (char.IsNumber(text[word][sym]))
                    {
                        temp++;

                    }
                }
                if (temp > Max)
                {
                    Max = temp;
                    Index = word;
                }
            }
            Console.WriteLine("Наибольше цифр в слове " + text[Index]);
        }

        public static void LongWord(string[] text)
        {
            int Max = 0;
            int Index = 0;
            for (int word = 0; word < text.Length; word++)
            {

                int tempNumOfIndex = 0;
                for (int sym = 0; sym < text[word].Length; sym++)
                {
                    tempNumOfIndex++;
                }
                if (tempNumOfIndex > Max)
                {
                    Max = tempNumOfIndex;
                    Index = word;
                }
            }
            Console.WriteLine("The longest word is " + text[Index]);
        }

        public static void ReplaceNum ( string text)
        { 
            string newtex = text.Replace("0", " zero ");
            string newtext1 = newtex.Replace("1", " one ");
            string newtext2 = newtext1.Replace("2", " two ");
            string newtext3 = newtext2.Replace("3", " three ");
            string newtext4 = newtext3.Replace("4", " four ");
            string newtext5 = newtext4.Replace("5", " five ");
            string newtext6 = newtext5.Replace("6", " six ");
            string newtext7 = newtext6.Replace("7", " seven ");
            string newtext8 = newtext7.Replace("8", " eight ");
            string newtext9 = newtext8.Replace("9", " nine ");
 
            Console.WriteLine(newtext9);
        }
        public static void SentComma(string [] txt)
        {
            foreach (string sentence in txt)
            {
                if (!sentence.Contains(','))
                    Console.WriteLine(sentence.Trim());
            }
        }
    }
}
