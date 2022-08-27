/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int[] array = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
Console.WriteLine($"{String.Join(" ", array)}");

bool result = IsTriangle(array); //является ли треугольком
if (result)  Console.WriteLine($"Треугольник может существовать");
else Console.WriteLine($"Треугольник НЕ может существовать");


int[] GetNumberFromUser(string message, string errorMessage)
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        while (true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
            {
                array[i] = userNumber;
                break;
            }
            else
                Console.WriteLine(errorMessage);
        }
    }
    return array;
}

bool IsTriangle(int[] array)
{
    bool result = false;
    if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1])
    {
        result = true;
    }
    return result;
}








