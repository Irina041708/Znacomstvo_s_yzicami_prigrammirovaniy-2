
// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Ведите день недели от 1 до 7: ");
string A = Console.ReadLine()??"";
int a;
if (int.TryParse(A, out a))
    {
        if  (a == 1) Console.WriteLine("Нет"); 
        if (a == 2) Console.WriteLine("Нет");
        if (a == 3) Console.WriteLine("Нет");
        if (a== 4) Console.WriteLine("Нет");
        if (a== 5) Console.WriteLine("Нет");
        if (a == 6) Console.WriteLine("Да");
        if (a == 7) Console.WriteLine("Да");
        
    }

