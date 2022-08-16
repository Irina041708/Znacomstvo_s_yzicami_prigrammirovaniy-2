/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


Console.Clear();
int [] arr = {1,2,8,2,1}; 

// Напишем метод вывода заданного массива на консоль
static void A(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}

// Напишем метод   Polindrom (arr)   - проверка на полиндромность нашего массива
static bool Polindrom (int[] array)
{
    int al = array.Length;
    for (int i = 0; i <= al/2; i++)
    if (array[i] != array[al-i-1])
    return false;
    return true;
}

// Выведем метод   Polindrom (arr)   с помощью метода   Polindrom2 (arr)   на консоль 
static void Polindrom2 (int[] array)
{
    if ((Polindrom (array))==false) 
    Console.Write ($"Пятизначное число  не является полиндромом ") ;
    if ((Polindrom (array))==true) 
    Console.Write ($"Пятизначное число является полиндромом ") ;
}

A (arr);
Polindrom2 (arr);



