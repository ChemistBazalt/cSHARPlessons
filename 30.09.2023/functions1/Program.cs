// 1 вид - ничего не аозвращают, ничего не принимают
void Method1()
{
    Console.WriteLine("my name katia");
}
// Method1();

// 2 вид - что-то принимает, но не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "text", count: 4); //именнованные аргументы

// 3 вид - ничего не принимают, но что-то возвращают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

// 4 вид - что-то принимают и что-то возвращают
string Method4(int count, string text) //возвращать строку, передавать int, char
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(5, "Hello! ");
Console.WriteLine(res);