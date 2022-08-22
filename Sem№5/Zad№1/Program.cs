/*31. Задайте массив из 12 элементов, заполенный числами из промежутка из [-9,9].
Найдите сумму отрицательных и положителных чисел.*/


Console.Clear();

int [] array = GetArray (12,-9,9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = GetpositiveSum(array);//сумма положительных числе
int negativeSum = GetNegativeSum(array);//сумма отрицательных чисел

Console.WriteLine ($"Positive Sum = {positiveSum}, Negative Sum = {negativeSum}");

///////////////////////////////////////////////////////////////////////////////////
//Возвращает массив из size элементов,
//заполненный случайными числами из промежутка [minValue, maxValue].
int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];// Создаем в памяти массив целых чисел с размером size
    for (int i=0; i < size ; i ++)
    {
        res [i] = new Random().Next (minValue, maxValue + 1);
    }
    return res;
}


// Возвращает сумму положительных чисел массива arr
int GetpositiveSum(int[] arr)
{
    int positiveSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveSum += el;
        
    }
    return positiveSum;

}

// Возвращает сумму отрицательных чисел массива arr
int GetNegativeSum (int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) negativeSum += el <0 ? el : 0 ;
       
    }
    return positiveSum;

}

