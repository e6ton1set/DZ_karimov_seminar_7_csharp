// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] GetColumnSumAvg(int[,] array)
{
    double[] avgSumArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            avgSumArray[i] = avgSumArray[i] + array[j, i];
        }
        avgSumArray[i] = avgSumArray[i] / array.GetLength(0);
    }

    return avgSumArray;
}

int[,] array = new int[5, 7];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 4);
    }
}

double [] result = GetColumnSumAvg(array);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
