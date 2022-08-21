/*  Задача 29: 
    Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33] 
*/

Console.Clear();
double [] array = new double [5]; //Массив из пяти элементов
double [] array2 = new double [3];

Console.WriteLine("Вводим массив из 5 элементов. ");
A(ref array); // Вызов метода с передачей параметров по ссылке (ref)
Console.Write("Массив из пяти элементов: ");
B(array) ; 

Console.WriteLine("Вводим массив из 3 элементов.");
C(ref array); // Вызов метода с передачей параметров по ссылке (ref)
Console.Write("Массив из трёх элементов: ");
D(array) ; 

static void A ( ref double  [] arr)
{
     try
     {
        Console.Write("Введите первый элемент массива: ");
        arr[0] = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите второй элемент массива: ");
        arr[1] = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите третий элемент массива: ");
        arr[2] = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите четвертый элемент массива: ");
        arr[3] = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите пятый элемент массива: ");
        arr[4] = double.Parse(Console.ReadLine() ?? "");
        
    }
    catch (Exception exc)
    {
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
    }
}

static void B (double[] array)
{
    double count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
        
    }
    Console.WriteLine();
}


static void C ( ref double  [] arr)
{
     try
     {
        Console.Write("Введите первый элемент массива: ");
        arr[0] = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите второй элемент массива: ");
        arr[1] = double.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите третий элемент массива: ");
        arr[2] = double.Parse(Console.ReadLine() ?? "");
        
    }
    catch (Exception exc)
    {
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
    }
}

static void D (double[] array)
{
    double count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
        
    }
    Console.WriteLine();
}
