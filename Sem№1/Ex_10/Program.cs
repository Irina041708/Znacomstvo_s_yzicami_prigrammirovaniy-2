
Console.WriteLine("Ведите первое число");
string A = Console.ReadLine()??"";
int a;
Console.WriteLine("Ведите второе число");
string B = Console.ReadLine()??"";
int b;
if ((int.TryParse(A, out a)) & (int.TryParse(B, out b)))
    {
        if (a == b*b) 
            {
                Console.Write(a); 
                Console.Write(" являетя квадратом ");  
                Console.WriteLine(b); 
            }
    
        else 
            {
                Console.Write(a); 
                Console.Write(" не являетя квадратом ");  
                Console.WriteLine(b);
            }
    }
else 
    {
    Console.Write(a); 
    Console.Write("не являетя квадратом ");  
    Console.WriteLine(b);
    }
    
