

//Задайте значения M и N. Напишите рекурсивный метод,
//который найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(SumNormalNumbers(N,M,0));

int SumNormalNumbers(int firstNumber, int secondNumber, int sum)
    {
        if (firstNumber != secondNumber)
        {
            sum += firstNumber++;
            sum = SumNormalNumbers(firstNumber, secondNumber, sum);
            return sum;
        }
        else
        {
            sum += firstNumber;
            return sum;
        }
    }
