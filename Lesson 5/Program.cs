using Lesson_5;


bool cont3 = true;

while (cont3 == true)
{
    
    Console.WriteLine("Enter text");
    var text1 = Console.ReadLine();
    string[] textChar = text1.Split(new char[] { ' ', '!', '?', '.' });

    bool cont1 = true;
    while (cont1 == true)
    {
        
        string menu = Actions.Menu();
        switch (menu)
        {
            case "1":
                Actions.MaxNumber(textChar);
                string ans = Actions.Continue();
                if (ans == "1")
                {
                    cont1 = true;
                }
                else if(ans == "2")
                {
                    cont1 = false;
                    cont3 = true;
                }
                else if (ans == "3")
                {
                    cont1 = false;
                    cont3 = false;
                }
                break;
            case "2":
                Actions.LongWord(textChar);
                ans = Actions.Continue();
                if (ans == "1")
                {
                    cont1 = true;
                }
                else if (ans == "2")
                {
                    cont1 = false;
                    cont3 = true;
                }
                else if (ans == "3")
                {
                    cont1 = false;
                    cont3 = false;
                }

                break;
            case "3":
                Actions.ReplaceNum(text1);

                ans = Actions.Continue();
                if (ans == "1")
                {
                    cont1 = true;
                }
                else if (ans == "2")
                {
                    cont1 = false;
                    cont3 = true;
                }
                else if (ans == "3")
                {
                    cont1 = false;
                    cont3 = false;
                }
                break;
            case "4":
                Actions.InterrogativeExclamatory(text1);

                ans = Actions.Continue();
                if (ans == "1")
                {
                    cont1 = true;
                }
                else if (ans == "2")
                {
                    cont1 = false;
                    cont3 = true;
                }
                else if (ans == "3")
                {
                    cont1 = false;
                    cont3 = false;
                }
                break;

            case "5":
                Actions.SentComma(text1);

                ans = Actions.Continue();
                if (ans == "1")
                {
                    cont1 = true;
                }
                else if (ans == "2")
                {
                    cont1 = false;
                    cont3 = true;
                }
                else if (ans == "3")
                {
                    cont1 = false;
                    cont3 = false;
                }
                break;

            case "6":
                Actions.StartEndOneLetter(text1);

                ans = Actions.Continue();
                if (ans == "1")
                {
                    cont1 = true;
                }
                else if (ans == "2")
                {
                    cont1 = false;
                    cont3 = true;
                }
                else if (ans == "3")
                {
                    cont1 = false;
                    cont3 = false;
                }
                break; 
        } 
    }
}


    

