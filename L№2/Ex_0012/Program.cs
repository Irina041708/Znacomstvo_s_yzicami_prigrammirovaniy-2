int [] array = {2,3,6,5,4,4,8,9,4};
int n = array.Length;
int find = 4;


int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
       Console.WriteLine(index); 
       break;
    }
    index++;
}
