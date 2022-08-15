void Zadacha50()
{
    //Напишите программу, которая на вход принимает
    //позиции элемента в двумерном массиве,
    //и возвращает значение этого элемента или же указание,
    //что такого элемента нет.
    Console.Write("Введите строку:");
    int pos_i = Convert.ToInt32(Console.ReadLine())-1 ;
    Console.Write("Введите столбец:");
    int pos_j = Convert.ToInt32(Console.ReadLine())-1 ;

    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

     for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write("", array[i, j]);
        }
      if (pos_i < 0 | pos_j > array.GetLength(0)-1 | pos_j < 0 | pos_j > array.GetLength(1)-1)
            {
                Console.WriteLine("Позиции не существует");
                break;
            }
            else
            {
                Console.WriteLine($"Значение в ячейке = {array[pos_i, pos_j]}");
                break;
            }
            Console.ReadLine();
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
Zadacha50();
