//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree( int number1, int number2)
{
    int degree = 1;
    for (int i=1; i<=number2; i++)
    {
        degree = degree * number1;
    }
    return degree;
}
Console.WriteLine("Input a number A");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The degree of {num1} for {num2} is {Degree( num1, num2 )}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigits ( int number)
// {
//     int sum = 0;
//     while (number!= 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Input a number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The number {number} has got sum of digits: {SumDigits(number)}");

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Enter a {i+1} element: ");
//         array [i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Array is: ");

//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.Write(" :) \n");
// }

// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n);
// ShowArray(myArray);