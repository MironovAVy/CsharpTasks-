﻿// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value_a = Prompt("Введите число");
Random rnd = new Random();
int p = rnd.Next();
int b =  rnd.Next();
while (p % value_a  != 0 && b % value_a  != 0 )
{
System.Console.WriteLine($"Числа {p} и {b} не деляться на {value_a} на цело ");
break;
}
