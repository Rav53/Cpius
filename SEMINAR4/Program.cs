void Zadacha25()
{
//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

Console.WriteLine("Возведене числа A в натуральную степень B");

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
}

void Zadacha27()
{
//Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    int Sum(int numberN)
    {   
        int count = Convert.ToString(numberN).Length;
        int advance = 0;
        int result = 0;

        for (int i = 0; i < count; i++)
        {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
        }
    return result;
    }

    int sum = Sum(numberN);
    Console.WriteLine("Сумма цифр в числе: " + sum);
}

void Zadacha29()
{
// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.


    Console.WriteLine("Введите числa через запятую: ");
    string seriesOfNumbers = Console.ReadLine();

    seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

    // функция удаления пробелов из строки 
    string RemovingSpaces (string series)
    {
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ') 
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
    }
    
    void СheckNumber2 (int  series)
    {

        if (series == '0'||series == '1'||series == '2'
        ||series == '3'||series == '4'||series == '5'||series == '6'
        ||series == '7'||series == '8'||series == '9'||series == ','
        ||series == '-');
        else 
        {
            Console.WriteLine("Ошибка ввода  символа. Вводи цифры.");
        }
    }

    // заполняем массив
    int[] ArrayOfNumbers(string seriesNew)
    { 

    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента
    int j =0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";
        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
        seriesNew1 += seriesNew[i];
        СheckNumber2(seriesNew[i]);
        i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
        if (i < seriesNew.Length-1)
        {
        arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
    }

    // функция  вывода массива на печать 
    void PrintArry(int[] coll)
    {
        int count = coll.Length;
        int index = 0;
        Console.Write("[");
        while(index < count)
        {
            Console.Write(coll[index]);
            index++;
            if (index < count)
            {
            Console.Write(",");
            }
        }
        Console.Write("]");
    } 
    
    string seriesNew = RemovingSpaces(seriesOfNumbers);
    int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);
    PrintArry(arrayOfNumbers);

}

//Zadacha25();
//Zadacha27();
//Zadacha29();