// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Array is: ");

//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();

// }

// int Even (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i<array.Length; i++)
//         if (array[i] % 2 == 0) count++;
//     return count;
// }
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n);
// ShowArray(myArray);
// Console.WriteLine($"Count of Even elements is:"+ Even(myArray));

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue+1);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("Array is: ");

//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// int SumNotEven(int[] array)
// {
//     int sum = 0;
//     for (int i=1; i<array.Length; i+=2)
//         sum+=array[i];
//     return sum;
// }
// Console.Write("Input a number of elements: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min of elements: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max of elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);
// Console.WriteLine($"Sum not even elements is:"+SumNotEven(myArray));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void CreateRandomArray (double[] array)
{
     for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(1,1000)) / 10;
        }
}
void ShowArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

void Difference (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            {
                max = array[i];
            }
        if (array[i] < min)
            {
                min = array[i];
            }
    }
    Console.WriteLine($"Max element is {max}. Min element is {min}");
    Console.WriteLine($"Difference from max to min = {Math.Round((max-min),1)}");
}
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
CreateRandomArray(array);
Console.WriteLine("Array: ");
ShowArray(array);
Difference(array);
