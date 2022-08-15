

void Zadacha47()
{
    //Задайте двумерный массив размером m×n,
    // заполненный случайными вещественными числами.

    Random random = new Random();
    int rows = random.Next(4, 4);
    int columns = random.Next(4, 4);
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);

}

void FillArray(double[,] array, int startNum = 0, int finishNum = 10)
{
    finishNum++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(random.NextDouble()*11,2);
        }
    }

}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Zadacha47();

