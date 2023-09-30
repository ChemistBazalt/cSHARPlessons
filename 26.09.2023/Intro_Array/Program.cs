//описываем функцию
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 45;
int b1 = 534533;
int c1 = 43;
int a2 = 165463;
int b2 = 52343;
int c2 = 7453452;
int a3 = 123;
int b3 = 754648;
int c3 = 54;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);


Console.WriteLine(max);