/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел. */
 Console.WriteLine("Ведите первое число");
string A = Console.ReadLine()??"";
int a;

Console.WriteLine("Ведите второе число");
string B = Console.ReadLine()??"";
int b;

Console.WriteLine("Ведите третье число");
string C = Console.ReadLine()??"";
int c;

if (
    (int.TryParse(A, out a)) &
     (int.TryParse(B, out b)) &
     (int.TryParse(C, out c))
     )

     {
        int max = a;

            if (max < b) 
                {
                    max = b;
                    Console.Write(b); 
                    Console.WriteLine(" -максимальное число ");
                }
            
            if (max < c) 
                {
                    max = c;
                    Console.Write(c); 
                    Console.WriteLine(" -максимальное число ");
                }

            else
                {
                    max = a;
                    Console.Write(a); 
                    Console.WriteLine(" -максимальное число "); 
                }
    }
           
