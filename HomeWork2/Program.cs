//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int SecondDigit(int num)
{
    int desEd = num % 100;
    int second = desEd / 10;
    return second;
}
Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecondDigit(num));

