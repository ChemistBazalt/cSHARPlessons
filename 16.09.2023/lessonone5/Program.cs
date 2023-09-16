// Набор гирь с разным весом
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

// Изначально представим, что гиря "а" имеет максимальный вес
int max = a;

//если значение первой гири больше, чем макимум, то в максимум нужно положить новое значение
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e; 

//показать на экране максимальную гирю
Console.Write("Max = ");
Console.WriteLine(max);