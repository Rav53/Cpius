//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckermannFunction(N,M));
int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        return 0;
    }


