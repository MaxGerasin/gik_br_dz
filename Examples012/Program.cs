﻿// Дан текст, В тексте нужно пробелы заменить черточками, маленькие "к"
// большими "К", а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместонашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короляю. "
+ "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             01234
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;        // показывает количество символов в строке
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);