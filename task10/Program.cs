﻿// Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100,1000);
int a = num/10%10;
Console.WriteLine($"Вторая цифра числа {num} -> {a}");
