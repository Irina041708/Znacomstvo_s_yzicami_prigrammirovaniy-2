/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Clear();
int I = 1;
Ref(ref I); // Вызов метода с передачей параметров по ссылке (ref)
Main(I); // Вызов метода с передачей параметров по значению

static void Ref(ref int i)
{
    try
    {
        Console.Write("Введите число: ");
        i = int.Parse(Console.ReadLine() ?? "");
        
    }
    
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void Main (int i )
{
    for (int a = 1; a <= i; a++)
    {
        
        double cub = System.Math.Pow ((a),3);
        Console.WriteLine($"{cub}");
        Console.WriteLine ();  
        
    }
}

// ---------------------- Конец определения методов ----------------------------