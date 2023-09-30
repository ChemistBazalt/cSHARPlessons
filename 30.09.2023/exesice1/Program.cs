// в тексте заменить: 1) пробелы чёрточками; 2)маленькие к на К; 3) С на с.
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде," 
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// обращаться к символу, отсчитывая его позоцию с нуля
// string s = "qwerty"
//             012345
// s[3] - s индентификатор строки, 3й символ - "r"

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; //количество символов в строке
    for (int i = 0; i < length; i++) //пробегаемся по символам в строке
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string nText = Replace(newText, 'к', 'К');
Console.WriteLine(nText);
Console.WriteLine();

string cText = Replace(nText, 'с', 'С');
Console.WriteLine(cText);
Console.WriteLine();