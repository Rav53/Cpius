

    //Задача 34: Задайте массив заполненный случайными
    //положительными трёхзначными числами. Напишите
    //программу, которая покажет количество чётных чисел в
    //массиве.
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);

    int chetnum = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i] % 2 == 0)
        {
        chetnum++;
        }
    }
    Console.WriteLine($"Чётных чисел:" + chetnum);


//Zadacha34();


void FillArray(int[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = random.Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
      Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}    