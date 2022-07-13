//Zadacha13();


//Задача 13: Напишите программу, которая с помощью деления
//выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
void Zadacha13()
{
    Console.WriteLine("Введите число:");
    int x = Convert.ToInt32(Console.ReadLine());
    int result = Math.Abs(x);
    int test = (result / 100);

    while (result > 1000)
            {
                result /= 10;   
            }
        if (test == 0)
            {
                Console.WriteLine("нет третьего числа");
            }
        else 
            {
            Console.WriteLine($"Третье число = {result % 10}");
            }
}
     
//Zadacha13();

