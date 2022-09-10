 //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(99,1000);
void second()
{
int p = number;
double a = p%10;
double b = p%100;
System.Console.WriteLine($"Ваше число ={p}");
System.Console.WriteLine($"Ваше число без второй цифры равно = { p/10 - (b-a)/10 + a}");
}
second();

