/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> yes
a = 2; b = 10 -> no
a = 9; b = -3 -> yes
a = -3; b = 9 -> no
*/
Console.WriteLine("Введите первое число:");
string numberOneStr = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string numberTwoStr = Console.ReadLine();

int numberOne = Convert.ToInt32(numberOneStr);
int numberTwo = Convert.ToInt32(numberTwoStr);

if (numberOne == numberTwo * numberTwo)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}