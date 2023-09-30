//метод для заполнения массива случайным числами
void FillArray (int[] numForArray)
{
    int length = numForArray.Length;
    int index = 0;
    while (index < length)
    {
        numForArray [index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] partsOfArray)
{
    int count = partsOfArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(partsOfArray[position]);
        position++;
    }
}

int IndexOf (int[] numForArray, int find)
{
    int count = numForArray.Length;
    int index = 0;
    int pos = 0;
    while (index < count)
    {
        if (numForArray[index] == find)
        {
            pos = index;
            break;
        }
        index ++;
    }
    return pos;
}


int[] nameArray = new int[10]; //new int[количество эл-тов в массиве]"создай новый массив, в котором 10 элтов"
FillArray(nameArray);
PrintArray(nameArray);
Console.WriteLine();
int position = IndexOf(nameArray, 4);
Console.WriteLine(position);