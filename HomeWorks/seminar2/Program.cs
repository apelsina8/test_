/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int CupNumber (int num) 
{
    int result = num / 10 % 10; 
    return result;     
}
        int RandomNumber = new Random().Next(456, 919);
        int result = CupNumber(RandomNumber);
        Console.WriteLine($" Искомое число {result}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int CupNumber (int num) 
{
    if (num == RandomNumber)     <<<-------------------тут у меня затык
    {
    int result = num % 10; 
    return result;
    }
    else
    {
        Console.WriteLine("-> Третьей цифры нет");
    }  
}
        int RandomNumber = new Random().Next(456, 457);
        int result = CupNumber(RandomNumber);
        Console.WriteLine($" Искомое число {result}");
*/



/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool TrueOfFalse(int num)
{
    if (num == 6 || num == 7)
    return true;
    else return false;
}


Console.WriteLine("num ");
int num = Convert.ToInt32(Console.ReadLine());
bool IsDivisionable = TrueOfFalse(num);
Console.WriteLine(IsDivisionable);
