int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Cube(Prompt("Введите целое число: "));
void Cube(int value)
{
    for (int i = 1; i <= value; i++)
    {
        System.Console.Write(Math.Pow(i, 3));
        if (i < value)
        {
            System.Console.Write(",");
        }
       
    }
}