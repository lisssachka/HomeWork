// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom (int num)
{
  int oldValue = num;
  int newValue = 0;
  while (num > 0)
  {
    int dig = num % 10;
    newValue = newValue * 10 + dig;
    num = num / 10;
  }
  if (newValue == oldValue)
  {
    Console.WriteLine("A number is Palindrom");
  }
  else
  {
    Console.WriteLine("A number isn't Palindrom");
  }   
}
            
Console.Write("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double dx = x2 - x1;
//     double dy = y2 - y1;
//     double dz = z2 - z1;
//     return Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2)+Math.Pow(dz,2));
// }
// Console.Write("Enter x coordinate 1st point ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter y coordinate 1st point ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter z coordinate 1st point ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter x coordinate 2nd point ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter y coordinate 2nd point ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter z coordinate 2nd point ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2);
// Console.WriteLine($"Distance ({x1},{y1}, {z1}) and ({x2},{y2}, {z2}) is {result}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Cube (int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         Console.Write($"{count*count*count} ");
//         count++;
//     }
// }
// Console.WriteLine("Enter a number ");
// int num = Convert.ToInt32(Console.ReadLine());

// Cube(num);

