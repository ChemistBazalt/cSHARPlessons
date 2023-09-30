int [] nameArray = {11, 12, 13, 14, 15, 16, 17, 18};
//Узнаём количество элементов массива (длшинну)
int n = nameArray.Length;
// какой из элементов нам надо найти?
int find = Convert.ToInt32(Console.ReadLine());
// устанавливаем счётчик индекса
int index = 0;

while (index < n) //если индекс меньше длины массива
{
    if (nameArray[index] == find)
    {
        Console.WriteLine(index);
        break; //останавливает после первого найденого элеимента
    }
    //каждый раз индекс будет увеличиваться на 1
    index ++;
}



// Console.WriteLine(n);