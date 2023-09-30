// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }

// string Method4(int count, string text) //возвращать строку, передавать int, char
// {
//     // int i = 0;
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(5, "Hello! ");
// Console.WriteLine(res);

// ЦИКЛ В ЦИКЛЕ "ВЫВОД ТАБЛ УМНОЖ НА ЭКРАН"

for (int i = 2; i <= 10; i++)
{  
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}