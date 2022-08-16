Console.Clear();
int number;
Console.Write("ВВедите любое число: ");
number = int.Parse(Console.ReadLine()?? "" );
number = countNumber (number); 
Console.Write ($"Число состоит из {number} цифр");

int countNumber (int num) 
{
    int i = 0;
    while (num > 0)
    {
        num/=10;
        i++;
    }
    return i;
}