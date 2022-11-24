// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//  void ShowNums (int n)
// {
//     Console.Write(n+" ");
//     if(n>1) ShowNums(n-1);

//     }
  
// Console.Write("Input N ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNums(n);
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int SumNumbers(int m, int n)
// {
//     if (m == 0) return (n * (n + 1)) / 2;            
//             else if (n == 0) return (m * (m + 1)) / 2;       
//             else if (m == n) return m;                       
//             else if (m < n) return n + SumNumbers(m, n - 1); 
//             else return n + SumNumbers(m, n + 1);            
// }
// Console.Write("Input M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input N ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(SumNumbers(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int AkkermanFunction(int m, int n)
{
    if (m==0) return n+1;
    if (n==0) return AkkermanFunction(m-1,1);
    if ((m>0) && (n>0)) return AkkermanFunction(m-1, AkkermanFunction(m,n-1));
    else return 0;
}
Console.Write("Input M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({m},{n}) = {AkkermanFunction(m,n)}");