// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");


        }
        Console.WriteLine();
    }
}
string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
}

int[,] array = FillArray(4, 4);


PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));