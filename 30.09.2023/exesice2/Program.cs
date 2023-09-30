//алгоритм сортировки от меньшего к большему
// массив, который будем сортировать
int [] arr = {5, 4, 9, 4, 1, 8, 3, 7, 2, 6};
// метод для вывода массива на экран
void PrintArray (int[] array) // массив в качетве аргумента
{
    //получаем количество элементов
    int count = array.Length;

    //пробегаем по всем элементам массива
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод, который упорядочивает наш массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        // определяем позицию, на которую смотрим
        int minPosition = i; // начальный элемент -  минимальный
        //ищем max элемент
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            
        }
        // меняем элементы местами
        int temporary = array [i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);