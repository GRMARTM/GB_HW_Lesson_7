/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] arr = new int[5, 5];

FillArray(arr);
void FillArray(int[,] arra)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 5);
        }
    }
}

Console.WriteLine("В заданном массиве:");
PrintArr(arr);
void PrintArr(int[,] arry)

{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");

double[] arithmeticMean = new double[arr.GetLength(1)];

for (int i = 0; i < arr.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        result += arr[j, i];
    }
    arithmeticMean[i] = result / arr.GetLength(0);
}
PrintArray(arithmeticMean);
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],4}");
    }
    Console.WriteLine();
}