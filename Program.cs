﻿/* Напишите программу, которая на вход принемает число и выдает его квадрат(число умноженное на само себя).

Например:
4->16
-3 -> 9
-7 -> 49
*/


Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int result = number * number;

Console.WriteLine($"Квадрат числа {number} равен = {result}"); /// " Кввадрат числа 2 равен = 4"
