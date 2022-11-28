// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
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
// Console.Write("Input a min value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// SortToLower(myArray);
// Console.WriteLine();
// Show2dArray(myArray);
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// int FindMinSum (int [,] array)
// {
//     int minSum =  0;
//     int numMinRows = 1;

//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {minSum+= array[0,k];}


//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum+=array[i,j];
//             }

//             if (sum < minSum) 
//             {
//                 minSum = sum;
//                 numMinRows = i+1;
//             }
//         }
//     // return numMinRows;
//     }
//     else Console.Write("Array is square!\n");
//     return numMinRows;
// }
// Console.Write($"Rows with min sum of elements is {FindMinSum(myArray)}");
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] CompositionArray (int[,] firstArray, int[,] secondArray)
// {
//     if (firstArray.GetLength(1) == secondArray.GetLength(0))
//     {
//         int[,] compositionArray = new int[firstArray.GetLength(0),secondArray.GetLength(1)];
//         for (int i = 0; i < firstArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < secondArray.GetLength(1); j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < firstArray.GetLength(1); k++)
//                 {
//                     sum += firstArray[i,k]*secondArray[k,j];
//                 }
//                 compositionArray[i,j] = sum;
//             }
//         }
//     return compositionArray;
//     }
//     else return firstArray;
// }
// Console.Write("Input a number of rows for first array");
// int rowsFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns for first array");
// int columnsFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min value for first array");
// int minFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max valuefor first array");
// int maxFirst = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(rowsFirst, columnsFirst, minFirst, maxFirst);
// Show2dArray(myArray);

// Console.Write("Input a number of rows for second array");
// int rowsSecond = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns for second array");
// int columnsSecond = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min value for second array");
// int minSecond = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max valuefor second array");
// int maxSecond = Convert.ToInt32(Console.ReadLine());

// int[,] myArraySecond = CreateRandom2dArray(rowsSecond, columnsSecond, minSecond, maxSecond);
// Show2dArray(myArraySecond);
// int [,] resultArray = CompositionArray(myArray, myArraySecond);
// Show2dArray(resultArray);

// не готова
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//не готова!!!

// int[,,] CreateRandom3dArray(int rows, int columns, int third)
// {
//     int[,,] array = new int[rows, columns, third];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < third; k++)
//             {
//                 array[i, j, k] = new Random().Next(10,100);
//             }
//     return array;
// }
// void Show3dArray(int[,,] array)
// {
//     Console.WriteLine("Array is: ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i}, {j}, {k})");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();        
//     }
    
// }
// Console.Write("Input a X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a Y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a Z");
// int z = Convert.ToInt32(Console.ReadLine());
// int [,,] myArray = CreateRandom3dArray(x, y ,z);
// Show3dArray(myArray);
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] SpiralArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     int iStart = 0;
//     int iEnd = 0;
//     int jStart = 0;
//     int jEnd = 0;
//     int i = 0;
//     int j = 0;
//     for (int k = 0; k < array.Length; k++)
//     {
//         array[i, j] = k + 1;
//         if (i == iStart && j < array.GetLength(1) - jEnd - 1)
//             j++;
//         else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - iEnd - 1)
//             i++;
//         else if (i == array.GetLength(0) - iEnd - 1 && j > jStart)
//             j--;
//         else
//             i--;

//         if ((i == iStart + 1) && (j == jStart) && (jStart != array.GetLength(1) - jEnd - 1))
//         {
//             iStart++;
//             iEnd++;
//             jStart++;
//             jEnd++;
//         }
//     }
//     return array;
// }
// Console.Write("Input a number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = SpiralArray(m, n);
// Show2dArray(array);
