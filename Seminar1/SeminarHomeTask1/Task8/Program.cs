﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int index = 1;
while (index < num+1)
if (index%2 ==0)
{Console.Write(index + ", ");
    index++;
}
else
{
    index++;
}
