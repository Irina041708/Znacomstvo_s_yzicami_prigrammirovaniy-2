/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine("Ведите число");
string A = Console.ReadLine()??"";
int a;
if ((int.TryParse(A, out a)))

    {
        
        if(  a % 2 == 0)
        {
            Console.Write(a); 
            Console.WriteLine(" - является четным "); 
        }
        else 
        {
            
            Console.Write(a); 
            Console.WriteLine(" - не является четным "); 
        }
    }
