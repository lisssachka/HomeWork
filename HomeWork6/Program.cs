//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
// int CountNegative (int m)
// {
//     int count = 0;
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write($"Enter a number {i + 1}: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num < 0) count++;
//     }
//     return count;
// }
// Console.Write("Enter a count of elements: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Negative numbers are {CountNegative(m)}");

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Intersection (double k1, double b1, double k2, double b2)
{
    if (k1==k2)
    {
        if (b1==b2) Console.WriteLine("Two lines are equal");
        else Console.WriteLine("Two lines not intersection");
    } 
    else
    {
       double x = (b1-b2)/(k2-k1);
        double y = k1*x+b1;
        Console.WriteLine($"Lines intersection in ({x},{y})");
    }
}
Console.Write("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"First line y={k1}*x+{b1}");
Console.WriteLine($"Second line y={k2}*x+{b2}");
Intersection(k1, b1, k2, b2);

