// Задача 24. Напишите программу, которая принимает на вход число (А)
// и выдаёт
// а) сумму чисел от 1 до А (4 -> (1+2+3+4) -> 10);
// б) сумму цифр в числе А (4321 -> (4+3+2+1) -> 10 ).
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
Console.WriteLine("а) сумма чисел от 1 до А");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"\t{num} -> {sumNumbers}");
Console.WriteLine("б) сумма цифр в числе А");
Console.WriteLine($"\t{num} -> {GetSumDigits(num)}");
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
        return userNumber;
        Console.WriteLine(errorMessage);
    } 
 }
// Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}
// Возвращает сумму цифр в числе number
int GetSumDigits(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
return sum;
}
// Пример: 4321
// number = 4321
// sum = 0
// (number > 0) => (4321 > 0) => true => Переход в тело цикла
// итер. 1
// number % 10 = 4321 % 10 = 1
// sum = 0 + 1 = 1
// number = number / 10 = 4321 / 10 = 432
// (number > 0) => (432 > 0) => true => Переход в тело цикла
// итер. 2
// number % 10 = 432 % 10 = 2
// sum = 1 + 2 = 3
// number = number / 10 = 432 / 10 = 43
// (number > 0) => (43 > 0) => true => Переход в тело цикла
// итер. 3
// number % 10 = 43 % 10 = 3
// sum = 3 + 3 = 6
// number = number / 10 = 43 / 10 = 4
// (number > 0) => (4 > 0) => true => Переход в тело цикла
// итер. 4
// number % 10 = 4 % 10 = 4
// sum = 6 + 4 = 10
// number = number / 10 = 4 / 10 = 0
// number > 0 => 0 > 0 => false => Выход из цикла
// sum = 10
