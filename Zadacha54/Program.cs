
//54.Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
Random random = new Random();
int rows = random.Next(4, 4);
int columns = random.Next(4, 4);
double[,] array = new double[rows, columns];
FillArray(array);
Console.WriteLine($"\n Рандомный массив: ");
PrintArray(array);
ArraySort(array);
Console.WriteLine($"\n Отсортированный массив: ");
PrintArray(array);




void ArraySort(double[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns-1; k++)
            {
                double temp = 0;
                if (array[i, k] < array[i, k+1])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = temp;
                
                }
                
            }    
        }
    }
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
            array[i, j] = random.Next(startNum,finishNum);
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

