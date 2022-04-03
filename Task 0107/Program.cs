// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


void FillArray(double[,] array)
{
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    
}

void PrintArray(double[,] array)
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

double[,] array = new double[3,4];
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    
    {
        array[i, j] = random.NextDouble() * 10;
        Console.Write("{0:0.0}  ", array[i, j]);
    }
    Console.WriteLine();
}


FillArray(array);




