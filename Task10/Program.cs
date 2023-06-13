﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: "); 
int Number = Convert.ToInt32(Console.ReadLine()); // чтение строки и перевод в целое число 
Number = Math.Abs(Number); // вдруг ввели отрицательное число

// проверим, что число трёхзначное
if (99 < Number &&  Number < 1000)
    {
        Number = Number/10 - Number/100*10;    //целочисленно делим на 10 и вычитаем сотни переведенные в десятки
        Console.WriteLine($"Вторая цифра {Number}");
    }
else
    {
        Console.WriteLine($"Введенное число {Number} - не трёхзначное");
    }
