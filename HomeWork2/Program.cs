//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondDigit(int num)
{
    int desEd = num % 100;
    int second = desEd / 10;
    return second;
}
Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecondDigit(num));
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Third(int num)
{
    int result = 0;
    while(num >= 1000)
    {
        num = num / 10;
    }
    if (num < 100) 
    {
        result = -1;
    }
    else
    {
        result = num % 10;
    }
    return result;
}
Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

int result = Third(num);
if (result == -1)
{
    Console.WriteLine("There is no third digit");
}
else
{
    Console.WriteLine($"Third digit is {result}");
}
*/


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Day(int den)
{
    if(den>=6)
        return true;
    else
        return false;
}
Console.WriteLine("Enter the number of the day of the week");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Day(day));
