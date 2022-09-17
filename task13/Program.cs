//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int a = Prompt("Введите a");
int SumNumber(int a)
  {
    
    int counter = a;
    int b = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      b = a - a % 10;
      result = result + (a - b);
      a = a / 10;         
    }
   return result;
}
int sumNumber = SumNumber(a);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);