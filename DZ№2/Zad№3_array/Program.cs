
// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
int [] array = {1,2,3,4,5,6,7};
int n = array.Length;
Console.WriteLine("Введите число от 1 до 7");
int index = int.Parse(Console.ReadLine());
int find1 = 6;
int find2 = 7;
if (index > 0 && index < (n+1) )
{
    if ( index == find1 ||  index == find2 ) Console.WriteLine($"{index} - это выходной день "); 
    
    else  Console.WriteLine($"{index} - рабочий день ");
    
}
else  Console.WriteLine($"{index} -это число не от 1 до 7");