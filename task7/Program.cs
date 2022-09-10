
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int Value = Prompt("Введите трех значное число");
void second()
{
int p = Value;
int a = p%10;
if (p > 99 && p < 1000)
{
    System.Console.WriteLine($"Ваше число ={p}");
    System.Console.WriteLine($"Третья цифрa числа {p} -  {a}");
}
else
{
    System.Console.WriteLine($"Ваше число - не трехзначное");
} 
}
second();