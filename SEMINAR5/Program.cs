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

//--------------------------------------------------------------

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

//--------------------------------------------------------------
void Zadacha38()
{
    //Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным 
    //и минимальным элементов массива.
    int size = 4;
    Double[] array = new Double[size];
    FillArray(array);
    PrintArray(array);
    Double min = array[0];
    Double max = array[0];

    for (int i = 0; i < size; i++)
    {
      if (max < array[i])
      {
        max = array[i];
      }
      if (min > array[i])
      {
        min = array[i];
      }
    }
    Console.WriteLine($"Разница между max ({max}) и min ({min}) значниями = {max - min}");


void FillArray(Double[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = Convert.ToDouble(new Random().Next(1,11)) / 10;
    }
}

void PrintArray(Double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
      Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}    

//--------------------------------------------------------------

}
//Zadacha34();
//Zadacha36();
Zadacha38();

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