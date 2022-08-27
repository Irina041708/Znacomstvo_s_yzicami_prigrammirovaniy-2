/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/////////////////////////////////////////////////////////////////////////////////////////////
Console.Clear();

int[] array = GetArray(4, 0, 10);

Console.Write("Получился массив коэффициентов: [");
PrintArray(array);
Console.WriteLine("]");

PrintArray2(array);
/////////////////////////////////////////////////////////////////////////////////////////////


int[] GetArray(int m, int minValue, int maxValue)
{
    int[] result = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите коэффициент от 0 до 10 {i + 1}:  ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }

    return result;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");

    }

}



void PrintArray2(int[] inArray)
{

    
        if (array[0] - array[2] != 0 && array[1] - array[3] != 0)
        {
            
            double x = (((double)array[2] - (double)array[0])) * (-1) / (double)(array[3] - (double)array[1]);
            double y = ((double)array[0] * (double)array[3] - (double)array[1] * (double)array[2]) / ((double)array[3] - (double)array[1]);
           
            Console.WriteLine($"Две прямые пересекаются в точке с кординатми x = {x} и y = {y}");
        }
            
        else Console.WriteLine("Две прямые параллельны.Решения нет.");
    

}



/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/