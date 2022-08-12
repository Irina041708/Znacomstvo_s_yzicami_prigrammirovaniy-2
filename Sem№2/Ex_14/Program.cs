/*11. Напишите программу, которая выводит случайное
 трёхзначное число и удаляет вторую цифру этого числа.*/

Console.Clear();
int x = new Random().Next(100,1000);
string num = f(x);
Console.WriteLine ($" {x}");
Console.WriteLine ($" {num}");

string f(int x )
{
    int a1 = x/100;
    int a2 = x%10;
    string b1 = a1.ToString();
    string b2 = a2.ToString();
    string num = b1 + b2;
    return num;
}
