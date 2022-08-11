/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
// тернарный оператор
/*
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine(x % 2 == 0 ? "Число чётное" : "Число не чётное");
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
if(x % 2 == 0) {Console.WriteLine("Число чётное");}
else {Console.WriteLine("Число не чётное");}
