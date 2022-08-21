/*  
    Задача 25: 
    Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16 
*/

Console.Clear();
int a = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int b = GetNumberFromUser2("Введите целое натурально число B: ","Ошибка ввода!");

int degreeNumbers = GetdegreeNumbers(a,b);
Console.WriteLine($"\t{a} в степени {b} = {degreeNumbers}");



// Проверка ввода чисела a
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

// Проверка ввода чисела b
int GetNumberFromUser2(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber2);
        if(isCorrect)
        return userNumber2;
        Console.WriteLine(errorMessage);
    } 
}


// Возводим число а в степень b
int GetdegreeNumbers(int a, int b)
{   
    int result = 1;
    
    for (int i = 0; i <  b; i++)
    {
        result *=a;
                       
    }
    return result;
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


