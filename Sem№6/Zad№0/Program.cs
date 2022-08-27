// Напишите программу, которая перевернет одномерный массив
//(последний элемнет будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join("", array));//формирует единую строку

int[] ReversArray = ReversArray1(array);// Создаем новый массив и вписываем туда новые значения
Console.WriteLine(String.Join("", array));

ReversArray2(array);//Изменяет наш массив
Console.WriteLine(String.Join("",array));


int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;

}

int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReversArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}





