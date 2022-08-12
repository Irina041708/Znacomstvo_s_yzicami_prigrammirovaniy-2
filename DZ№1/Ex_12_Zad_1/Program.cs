/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.*/
 Console.WriteLine("Ведите первое число");
string A = Console.ReadLine()??"";
int a;
Console.WriteLine("Ведите второе число");
string B = Console.ReadLine()??"";
int b;
if ((int.TryParse(A, out a)) & (int.TryParse(B, out b)))
    {   if (a != b)
            if (a > b ) 
                {
                    Console.Write(a); 
                    Console.WriteLine(" -максимальное число ");  
                    Console.Write(b); 
                    Console.Write(" - минимальное число "); 
                }
        
            else 
                {
                    Console.Write(a); 
                    Console.WriteLine(" - минимальное число ");  
                    Console.Write(b); 
                    Console.Write(" - максимальное число "); 
                }
        else 
            {
            Console.Write(a); 
            Console.Write(" равно ");  
            Console.WriteLine(b);
            }

    }
