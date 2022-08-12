//написать программу , которая выводит случайное максимальное число из отрезка 
//[10,99]  и показывает наибольшую цифру
Console.Clear();
int x = new Random().Next(10,100);
int max = f(x);
Console.WriteLine ($"Максимальная цифра в числе {x} -> {max}");

int f(int x)
{
    int a1 = x/10;
    int a2 = x%10;
    int max = a1;
    if ( max < a2 )
    {
        max = a2;
    }
    return max;
}