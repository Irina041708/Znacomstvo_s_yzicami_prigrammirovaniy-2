/*Задача 21: Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 2D пространстве.*/
 

Console.Clear();


double X1 = 0, Y1 = 0, X2 = 0, Y2 = 0;
InitCoordinatesByUser(ref X1, ref Y1, ref X2, ref Y2); // Вызов метода с передачей параметров по ссылке (ref)
Main(X1, Y1, X2, Y2); // Вызов метода с передачей параметров по значению

static void InitCoordinatesByUser(ref double x1, ref double y1, ref double x2, ref double y2)
{
     try
     {
        Console.Write("Введите X1: ");
        x1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y1: ");
        y1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите X2: ");
        x2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y2: ");
        y2 = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
    }
}
// -----------------------------------------------------------------------------
// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и выводящую в консоль номер четверти плоскости, в которой находится эта точка
static void Main(double x1, double y1, double x2, double y2)
{
    
    Double Rez = (System.Math.Pow ((x1-x2),2))+ (System.Math.Pow((y1-y2),2));
    Double R = System.Math.Sqrt(Rez);
    Console.WriteLine($"{R}");
}

