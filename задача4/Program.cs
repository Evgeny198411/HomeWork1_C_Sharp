﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int i = 2;
if(n < i){Console.Write("Чётных положительных чисел нет");}
while(i <= n)
{
    if(i % 2 == 0) {Console.Write(i); }
    if(i + 2 <= n) {Console.Write(", "); }
    i += 2;
}
Console.WriteLine();
