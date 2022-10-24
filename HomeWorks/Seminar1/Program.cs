//                                             Задание 1
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/* int a, b;
Console.WriteLine("Введите два числа : ");
a = Convert.ToInt32(Console.ReadLine()); 
b = Convert.ToInt32(Console.ReadLine());
  if (a > b)
 
     { 
        Console.WriteLine($" max = {a}");
     }
     else
     {
        Console.WriteLine($"max = {b}");
      }
     Console.ReadLine();
*/
     //                                          Задание 2


/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
int a, b, c;
Console.WriteLine("Введите три числа : ");
a = Convert.ToInt32(Console.ReadLine()); 
b = Convert.ToInt32(Console.ReadLine());
c =Convert.ToInt32(Console.ReadLine());
if (a > b)
   if (a > c)
      { 
        Console.WriteLine($" max = {a}");
     }
     else
     {
        Console.WriteLine($"max = {c}");
     }
     
else if (b > c)
{
 Console.WriteLine($"max = {b}");
}
else
{
 Console.WriteLine($"max = {c}");
}
*/



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write ("Введите число : ");
int num = Convert.ToInt32 (Console.ReadLine ());
int result = num % 2;
if (result == 0)
{
    Console.WriteLine ("Это четное число!");
}
else
{
    Console.WriteLine ("Это нечетное число!");
}

//changes