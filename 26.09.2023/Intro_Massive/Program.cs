//описываем функцию
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//объявляем массив
//                  0   1   2   3   4   5   6   7   8
int [] nameArray = {11, 12, 13, 14, 15, 61, 17, 18, 19};
// обращаемся к элементу массива: имя_массива [индекс]
// nameArray [0] = 12; //присваеваем элементу массива с инд 0 другое значение
// Console.WriteLine(nameArray[0]);

int max = Max (nameArray[]);
Console.WriteLine(max);




// int max = Max(
//     Max(a1, b1, c1), 
//     Max(a2, b2, c2), 
//     Max(a3, b3, c3));
// Console.WriteLine(max);