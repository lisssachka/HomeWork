int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Array is: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// double[,] CreateRandomDouble2dArray(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(1, 1000)) / 10;

//     return array;
// }

// void ShowDouble2dArray(double[,] array)
// {
//     Console.WriteLine("Array is: ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandomDouble2dArray(m, n);
// ShowDouble2dArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

string ReturnPositionOfArray(int row, int column, int[,] array)
{
    if (row < array.GetLength(0) && column < array.GetLength(1))
        return $"Element with index ({row},{column}) = {array[row, column].ToString()}";
    return $"Error! Element with index ({row}, {column}) does not in array";
}
Console.Write("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of row position");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number of column position");
int column = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine(ReturnPositionOfArray(row, column, myArray));


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void ShowDoubleArray(double[] array)
// {
//     Console.WriteLine("Average array is: ");
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + "  ");
// }

// double[] AverageColumns(int[,] array)
// {
//     double[] newArray = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//             sum += array[j, i];
//         newArray[i] = Math.Round(sum / array.GetLength(0), 1);
//     }
//     return newArray;
// }
// Console.Write("Input a number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// double[] averageArray = AverageColumns(myArray);
// ShowDoubleArray(averageArray);
