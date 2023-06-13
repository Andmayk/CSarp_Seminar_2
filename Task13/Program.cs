// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: "); 
int Number = Convert.ToInt32(Console.ReadLine()); // чтение строки и перевод в целое число 

if (Number > 99)
{
    if (Number > 999)
    while (Number > 999)
    {
        Number /=10;
    }
    Number = Number%10;
     Console.WriteLine($"Третья цифра {Number}");
}
else
{
         Console.WriteLine($"Третьей цифры нет");
}