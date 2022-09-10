// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Value1 = Prompt("Введите a");
int Value2 = Prompt("Введите b");
int Value3 = Prompt("Введите c");
if (Value1 > Value2 && Value1> Value3)
{
    System.Console.WriteLine("a - максимальное");
}
if (Value2 > Value1 && Value2> Value3)
{
    System.Console.WriteLine("b - максимальное");
}
if (Value3 > Value1 && Value3  > Value2)
{
    System.Console.WriteLine("c - максимальное");
}
