
Console.WriteLine("Ведите день недели от 1 до 7: ");
string A = Console.ReadLine()??"";
int a;
if (int.TryParse(A, out a))
    {
        if  (a == 1) Console.WriteLine("Понедельник");
        if (a == 2) Console.WriteLine("Вторник");
        if (a == 3) Console.WriteLine("Среда");
        if (a== 4) Console.WriteLine("Четверг");
        if (a== 5) Console.WriteLine("Пятница");
        if (a == 6) Console.WriteLine("Суббота");
        if (a == 7) Console.WriteLine("Воскресенье");
        else Console.WriteLine("Ошибка ввода, внесите число от 1 до 7");
    }
else Console.WriteLine("Ошибка ввода");