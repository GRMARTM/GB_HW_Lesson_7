/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
1 1 -> 9 */

int[,] arr = new int[5, 5];

FillArray(arr);
void FillArray(int[,] arra)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 1000);
        }
    }
}
Console.WriteLine("Введите два числа:");
string[] sArr = Console.ReadLine().Split(' ');
int rows = Convert.ToInt32(sArr[0]);
int colums = Convert.ToInt32(sArr[1]);

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

if (rows < arr.GetLength(0) && colums < arr.GetLength(1)) 
{
    Console.WriteLine(arr[rows, colums]);
}
else Console.WriteLine($"{rows} {colums} -> такого числа в массиве нет");
