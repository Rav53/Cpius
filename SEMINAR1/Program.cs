void Zadacha2()
{
    // Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт,
    // какое число большее, а какое меньшее.
    Console.WriteLine("Введите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if ( numberA > numberB )
        {   
        Console.WriteLine($"Max = {numberA}");
        Console.WriteLine($"Min = {numberB}");
        }
    else if(numberA < numberB)
        {
        Console.WriteLine($"Max = {numberB}");
        Console.WriteLine($"Min = {numberA}");   
        }
    Console.WriteLine();
}

    void Zadacha4()
    {
        Console.WriteLine("Введите число A: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число C: ");
        int numberC = Convert.ToInt32(Console.ReadLine());
        int max = numberA;

            if (numberB > numberA)
            {
            max = numberB;
            }    
            if (numberC > numberA)
            {
            max = numberC;
            }
            Console.WriteLine($"Max = {max}");
    }

void Zadacha6()
    {
         Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number%2 == 0)
        {
        Console.WriteLine($"Четное = {number}");  
        }
        else
        {
        Console.WriteLine($"Нечетное = {number}");
        }   
    }   


//Zadacha2(); 
//Zadacha4();
//Zadacha6();














