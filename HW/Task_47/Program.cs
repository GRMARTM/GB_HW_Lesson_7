/*
Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Ввести размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести размер n ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Math.Round(new Random().NextDouble(),3);
    }
}

PrintArr(arr);

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j], 8}");
        }
        Console.WriteLine();
    }
}
// double x = Math.Round((new Random().NextDouble()* 10),2);
