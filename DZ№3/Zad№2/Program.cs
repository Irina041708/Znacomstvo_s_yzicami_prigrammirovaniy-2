/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();


double X1 = 0, Y1 = 0, Z1 = 0, X2 = 0, Y2 = 0, Z2 = 0;
Ref(ref X1, ref Y1,ref Z1, ref X2, ref Y2, ref Z2); // Вызов метода с передачей параметров по ссылке (ref)
Main(X1, Y1, Z1, X2, Y2, Z2); // Вызов метода с передачей параметров по значению

static void Ref(ref double x1, ref double y1,  ref double z1 , ref double x2, ref double y2,  ref double z2)
{
    try
    {
        Console.Write("Введите X1: ");
        x1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y1: ");
        y1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z1: ");
        z1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите X2: ");
        x2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y2: ");
        y2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Z1: ");
        z2 = double.Parse(Console.ReadLine() ?? "");
    }
      
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void Main(double x1, double y1, double z1, double x2, double y2, double z2)
{
    
    Double Rez = (System.Math.Pow ((x1-x2),2))+ (System.Math.Pow((y1-y2),2))+(System.Math.Pow((z1-z2),2));
    Double R = System.Math.Sqrt(Rez);
    Console.WriteLine($"{R}");
}



