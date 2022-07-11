// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Программа показывает сумму цифр в числе");
int GetNumber ()
{
    while (true)
    {
        Console.WriteLine ("Введите число");
        string valueFromConsole = Console.ReadLine();
        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0) return number;
            else
            {
                number *= -1;
                return number;
            }
        }
        else Console.WriteLine ("Введите корректное число");
    }
}

int GetResult (int num)
{
    int sum = 0;
    while (num > 0)
        {
            sum = sum + num % 10;
            num = num/10;
        }
    return sum;
}

int number = GetNumber();
Console.WriteLine("Сумма цифр в числе равна " + GetResult(number));
