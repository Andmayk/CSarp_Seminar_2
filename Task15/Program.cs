// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: "); 
byte DayNumber = Convert.ToByte(Console.ReadLine()); // чтение строки и перевод в целое число 
Number = Math.Abs(Number); // вдруг ввели отрицательное число
    
if (DayNumber < 6)
{
    Console.WriteLine($"{NumberDay} -> нет, будни");    
}
else if (DayNumber < 8)
{
    Console.WriteLine($"{NumberDay} -> да! выходной");    
}
else
{
    Console.WriteLine($"{NumberDay} -> не день недели");    
}