using Lesson_5;
using static System.Net.Mime.MediaTypeNames;

string menu ="";
bool cont = true;



while(cont == true)
{   

    Console.WriteLine("Enter text");
    var text1 = Console.ReadLine();
    string [] textChar = text1.Split(new char[] {' ', '!' , '?', '.' });

    Actions.Menu(ref menu);
    switch (menu)
    {
        case "1":
            Actions.MaxNumber(textChar);
            break;
        case "2":
            Actions.LongWord(textChar);
            break;
        case "3":
            Actions.ReplaceNum(text1) ;
            break;
        case "4":
           
            break;
        case "5":
           
            break;
        case "6":
            break;
    }
    Console.WriteLine("Do you want to continue?(+/-)");
    string cont1 = Console.ReadLine();
    if (cont1 == "+")
    {
        cont = true;
        continue;
    }
    else
        cont = false;
    break;
}

