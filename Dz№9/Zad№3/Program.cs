/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
Console.WriteLine("Введите первое неотрицательное число N:");
uint N = uint.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе неотрицательное число M:");
uint M = uint.Parse(Console.ReadLine() ?? "");

///Метод вычисления функции Аккермана:
uint AckermannFunction(uint N, uint M)
{
    if (N == 0) return M + 1;
    else
        if (N != 0 && M == 0) return AckermannFunction(N - 1, 1);
    else
        if (N > 0 && M > 0) return AckermannFunction(N - 1, AckermannFunction(N, M - 1));
    return 0;
}
if (AckermannFunction(N, M) == 0)
    Console.WriteLine($"Функция Аккермана для чисел A({N},{M}) = Ошибка ввода данных");
else
    Console.WriteLine($"Функция Аккермана для чисел A({N},{M}) = {AckermannFunction(M, N)}");
