/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.*/
Console.Clear();
int x = new Random().Next(0,100000);
Console.WriteLine ($" {x} - заданное число"); 
       
       if (x >= 0 && x < 100)
       {
                Console.WriteLine ($" Tретьей цифры заданного числа {x} нет"); 
       } 
       
       else if (x > 99 && x < 1000)
       {
                int a2 = x%10;
                string b2 = a2.ToString();
                string num = b2;
                Console.WriteLine ($" {num} - третья цифра заданного числа"); 
       }
        else if (x > 999 && x < 10000)
       {
                int a1 = x/10;
                int a2 = a1%10;
                string b2 = a2.ToString();
                string num = b2;
                Console.WriteLine ($" {num} - третья цифра заданного числа"); 
       }
       else if (x > 9999 && x < 100000)
       {
                int a1 = x/100;
                int a2 = a1%10;
                string b2 = a2.ToString();
                string num = b2;
                Console.WriteLine ($" {num} - третья цифра заданного числа"); 
       }

