//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int value_a = Prompt("Введите число");
if (value_a % 2 == 0)
{
    System.Console.WriteLine("число четно");
}
else
{
    System.Console.WriteLine("Введеное число не четное");
}
