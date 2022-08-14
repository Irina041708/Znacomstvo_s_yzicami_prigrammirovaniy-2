/*Упорядочить массивы.
 Наша задача — выбрать самый первый элемент и в оставшейся
части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, это
6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.
*/

int [] arr = {10,2,33,4,5,6}; 
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}

/*Напишем метод упорядочивания наего массива*/
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++ )
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray (arr);
SelectionSort (arr);
PrintArray (arr);
