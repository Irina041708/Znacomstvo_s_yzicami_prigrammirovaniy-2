/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] arra = GetArrayRand(5,1,10);
int[] arra2 = Arr1(arra);
Console.WriteLine($"{String.Join(" ", arra)}");
Console.WriteLine($"{String.Join(" ", arra2)}");




int[] GetArrayRand(int size, int minVal, int maxVal)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVal,maxVal+1);
    }
    return res;
}



int[] Arr1(int[] Arr)
{
    int[] result = new int[Arr.Length];
    for(int i=0; i<Arr.Length;i++)
    {
        result[i] = Arr[i];
    }
    return result;
}