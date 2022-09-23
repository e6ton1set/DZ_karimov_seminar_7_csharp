// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 1000;
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] resultArray = GetDoubleArray(m, n);

for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        Console.WriteLine($"{resultArray[i, j]}");
    }
}






// int GetSumDiagonalArray(int m, int n)
// {
//     int [,] array = new int [m, n];
//     int sum = 0;
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 5);
//             if (i == j)
//             {
//                sum = sum + array[i, j];
//             }
//         }
//     }
//     return sum;
// }

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int diagonalSum = GetSumDiagonalArray(m, n);
// Console.WriteLine(diagonalSum);
