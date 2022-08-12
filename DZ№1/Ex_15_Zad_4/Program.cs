/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. */
Console.WriteLine("Ведите число");
string N = Console.ReadLine()??"";
int n;
int i = 1;


if ((int.TryParse(N, out n)))

    {   while ( i <= n) 
                
            {
            if(  i % 2 == 0)
                {
                    Console.Write(i); 
                    Console.WriteLine(" - является четным "); 
                }
                
            i ++; 
            }
          
    }
