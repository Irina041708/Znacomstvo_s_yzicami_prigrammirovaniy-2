/*11. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деление.*/

Console.Clear();
int x = new Random().Next(100,100);
int y = new Random().Next(100,100);
string num = f(x,y);
Console.WriteLine ($" x = {x}, y = {y}");


string f (int x,int y )
{   int num = x % y;
    
    if (num == 0)
    {
        Console.WriteLine ($" {y} кратно {x} ");
    }
    else
    {
        
        Console.WriteLine ($" {y} не кратно {x}, остаток от деления {num}");
    }
    string n = num.ToString();
    return n;
}
