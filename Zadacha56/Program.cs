
void Zadacha56()
{
    //Задайте прямоугольный двумерный массив. Напишите программу,
    //которая будет находить строку с наименьшей суммой элементов.
    Random random = new Random();
    int rows = random.Next(3, 3);
    int columns = random.Next(3, 3);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    int sumMin = 0;
    int sum = SumRows(array,0);
        for (int i = 0; i < rows; i++)
        {
            int tempSum = SumRows(array, i);
            if (sum > tempSum)
            {
                sum = tempSum;
                sumMin = i; 
            }              
        }
        Console.WriteLine($"\n Cтрокa с наименьшей суммой: {sumMin+1} , Сумма строки = {sum} ");
        Console.WriteLine();
                
}

Zadacha56();

int SumRows(int[,] array, int i)
{
    int sumRows = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRows += array[i, j];
    }
    return sumRows;
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
            array[i, j] = random.Next(startNum, finishNum);
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