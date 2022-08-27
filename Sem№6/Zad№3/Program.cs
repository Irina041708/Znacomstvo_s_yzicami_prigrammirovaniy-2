/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

...........................................

String res = String.Empty;
do
{
    res += n % 2;
    n /= 2;
}
while (n > 0);
Console.Write(res.Reverse().ToArray());

int GetInt(string msg)
{
    Console.Write(msg);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.WriteLine("Ошибка ввода");
        Console.WriteLine(msg);

    }
}
