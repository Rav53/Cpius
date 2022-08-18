void Zadacha52()
{
    //Задайте двумерный массив из целых чисел.
    //Найдите среднее арифметическое элементов в каждом столбце.

    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    
    for (int j = 0; j < columns; j++)
    {
        double Sum = 0;
        for (int i = 0; i < rows; i++)
        {
            Sum += array[i,j];
            
        }
            Console.WriteLine($"Среднее арифметическое столбцов:{Sum / array.GetLength(0)}");
    }


void FillArray(int[,] array, int startNum = 0, int finishNum = 10)
{
    finishNum++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNum,finishNum);
        }
    }

}

void PrintArray(int[,] array)
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
}
Zadacha52();