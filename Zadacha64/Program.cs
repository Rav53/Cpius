Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());

NormalNumber(N,M);
 void NormalNumber(int firstNumber, int secondNumber)
    {
        if (firstNumber != secondNumber)
        {
            if (firstNumber % 3 == 0)
            {
                Console.Write(firstNumber++ + " ");
                NormalNumber(firstNumber, secondNumber);
            }
            else
            {
                NormalNumber(++firstNumber, secondNumber);
            }
        }
        else
        {
            Console.Write(firstNumber);
        }
    }