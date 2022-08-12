/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.*/
Console.Clear();
int x = new Random().Next(100,1000);
string num = f(x);
Console.WriteLine ($" {x}");
Console.WriteLine ($" {num} - второе число из трехзначного числа");

string f(int x )
{
    int a1 = x/10;
    int a2 = a1%10;
    string b2 = a2.ToString();
    string num = b2;
    return num;
}



    
   
