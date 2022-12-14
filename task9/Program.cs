int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    if (int.TryParse(strValue, out int value))
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число.");
}
int value = Prompt("Введите пятизначное число: ");
if (NumbersCheck(value))
{
    System.Console.WriteLine(Palindrome(value) ? 
        $"{value} -> да" : $"{value} -> нет");
}
else System.Console.WriteLine("Введено непятизначное число.");

bool NumbersCheck (int value)
{
    if (value > 9999 && value < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool Palindrome(int value)
{
    bool rez = true;
    int count = value.ToString().Length;
    int[] nums = new int [count];
    for (int i = 0; i < count; i++)
    {
        nums[i] = value % 10;
        value /= 10;
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != nums[nums.Length - i - 1])
        {
            rez = false;
            break;
        }
    }
    return rez;
}
