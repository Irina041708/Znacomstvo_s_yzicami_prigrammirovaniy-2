/*  Задача 29: 
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33] */


Console.Clear();
int [] arr = {1,2,5,7,19}; 
int [] arr2 = {6,1,33}; 

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


// Напишем метод вывода заданного массива на консоль
static void B(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}


A (arr);
B (arr2);




