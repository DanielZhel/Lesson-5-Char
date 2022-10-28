namespace Lesson_5
{
    public class Actions
    {
        public static string Continue() 
        {
            string ans;
            Console.WriteLine("1.Do actions one more time.");
            Console.WriteLine("2.Exit to enter the new text.");
            Console.WriteLine("3.Close the programm.");
            ans = Console.ReadLine();

            return ans;
        }
        public static string Menu()
        {
            bool repeat = true;

            string menu = "";

            while (repeat == true)
            {
                Console.WriteLine("Choose on of the action:");
                Console.WriteLine("1.Find words containing the maximum number of digits.");
                Console.WriteLine("2.Find the longest word and determine how many times it occurs in the text.");
                Console.WriteLine("3.Replace the numbers from 0 to 9 with the words 'zero', one', ..., 'nine'.");
                Console.WriteLine("4.Display first interrogative and then exclamatory sentences.");
                Console.WriteLine("5.Display only sentences that do not contain commas.");
                Console.WriteLine("6.Find words that start and end with the same letter.");
                menu = Console.ReadLine();


                if (menu == "1"|| menu == "2"||menu == "3"|| menu == "4"|| menu =="5"|| menu == "6")
                {
                    repeat = false;
                   
                }
                else
                {
                    Console.WriteLine($"There is no '{menu}' action. Try again!");
                    repeat = true;
                }
                
            }
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
            string[] WordToString = new string[10] { " zero ", " one ", " two ", " three ", " four ", " five ", " six ", " seven ", " eight ", " nine " };

            for(int i = 0; i < 10; i++)
            {
                text = text.Replace(i.ToString(), WordToString[i]);
            }
            Console.WriteLine(text);
            
        }
        public static void SentComma(string txt)
        {
            string [] sents = txt.Split ('.', '!', '?');
            foreach (string sentence in sents)
            {
                if (sentence.Contains(',') == true)
                {
                    Console.WriteLine(sentence);
                }
            }
        }

        public static void InterrogativeExclamatory(string txt)
        {
            string[] sent = txt.Split('.');
            foreach(string sentence in sent)
            {
                if (txt.Contains('!') == true)
                { 

                }
            }
        }
        
        public static void StartEndOneLetter (string txt)
        {
            string[] word = txt.Split('.', ' ', '!', '?');
            for (int i = 0; i < word.Length; i++)
            {
                char [] sim = word[i].ToCharArray();
                for (int j = 0; j < sim.Length-1; j++)
                {
                    if (sim[j] == sim[(word[i].Length - 1)])
                    {
                        Console.WriteLine(word[i]);
                        break;
                    }
                    else if (sim[j] != sim[(word[i].Length - 1)])
                    {
                        break;
                    }

                }
            }
        }
    }
}
