void Zadacha34()
{

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
}

void Zadacha36()
{
//Задача 36: Задайте одномерный массив,
// заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

    int size = 4;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);

    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if(i % 2 == 0) 
        {
        sum = sum + array[i];
        }
    }
        Console.WriteLine($"Сумма чисел в нечётных позициях = " + sum);
}

Zadacha34();
//Zadacha36();

void FillArray(int[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = random.Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}    