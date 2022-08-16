Console.Clear();
Console.WriteLine("ВВедите любое число: ");
int userNumber = int.Parse(Console.ReadLine()?? "" );
int factorial = calculatorFactorial (userNumber); 
Console.Write ($"Факториал числа {userNumber} = {factorial} ");

int calculatorFactorial (int num) 
{
    int result = 1, i = 1;
    while (i<=num)
    {
        result*=i;
        i++;
    }
    return result;
}