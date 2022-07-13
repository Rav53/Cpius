//Zadacha13();
Zadacha15();


void Zadacha13()
{
//Задача 13: Напишите программу, которая с помощью деления
//выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

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


void Zadacha15()
{     
//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.


    Console.WriteLine("Введите номер дня недели от 1 до 7:");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day < -1 || day > 7)
        {
          Console.WriteLine("В неделе вообще то всего 7 дней! Перегрузка! Ошибка! Errrrrr=))");  
        }
        else if (day == 6 || day == 7)
        {
            Console.WriteLine("Выходной");
        }
        else if (day >= 1 && day <= 5)
        {
            Console.WriteLine("Рабочий день");
        }

}
//Zadacha13();
//Zadacha15();

