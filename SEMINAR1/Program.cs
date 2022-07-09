void Zadacha2() 
{
    // Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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

