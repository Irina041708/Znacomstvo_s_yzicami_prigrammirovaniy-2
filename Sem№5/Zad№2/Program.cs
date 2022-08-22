/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]  */


Console.Clear();

Console.WriteLine($"Наш массив");
int[] array = GetArray(4, -9, 9);

Console.Write($"[ ");
Console.Write($" {String.Join(" ", array)}");
Console.WriteLine($"]");

array = GetReplace (array);

Console.Write($"[ ");
Console.Write($" {String.Join(" ", array)}");
Console.Write($"]");

///////////////////////////////////////////////////////////////////////////////////

//Возвращает массив из size элементов,
//заполненный случайными числами из промежутка [minValue, maxValue].
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];// Создаем в памяти массив целых чисел с размером size
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

//Возвращает замену элементов массива arr

int [] GetReplace(int[] arr)
{

    for (int el = 0; el < arr.Length; el++)
    {
        arr[el] *= (-1);
    }

    return arr;

}


