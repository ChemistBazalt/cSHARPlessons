Console.Clear(); //очищаем консоль
// рисуем точки в виде +, для расположения используем SetCursorPosition(колво символов слева, колво строк)
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

// обозначаем вершины треугольника
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

// рисуем в консоли вершины треугольника
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// опеределяем первую точку с координатами ха, хb
int x = xa, y = xb;
// изначальное количство итерраций цикла
int count = 0;

while (count < 10000) //пока количество иттераций меньше 10
{
    int what = new Random().Next(0, 3); // рандомно выбираем вершину треугольника????
    
    // находим середину отрезка
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

// Рисуем середину отрезка
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count ++; //счётчик иттераций послед выполнения будет становиться на 1 больше
}

