//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int N = Prompt("Введите число");
for (int I=2; I<=N; I=I+2)
{
    System.Console.WriteLine($"   {I} ");
}
