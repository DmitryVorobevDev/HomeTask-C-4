// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Программа позволяет возвести число А в стпень равную числу B");
int GetNumbers (string msg)
{
    while (true)
    {
        Console.WriteLine (msg);
        string valueFromConsole = Console.ReadLine();
        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0) return number;
            else Console.WriteLine ("Введите положительное число");
        }
        else Console.WriteLine ("Введите корректное число");
    }
}


int GetResult (int numA, int numB)
{
    int tempNumA = numA;
    for (int i = 0; i < numB - 1; i++)
    {
        numA = numA * tempNumA;
    }
    return numA;
}

string MessageA = "Введите положительное число А : ";
string MessageB = "Введите положительное число B : ";

int numA = GetNumbers(MessageA);
int numB = GetNumbers(MessageB);


Console.WriteLine ("Число А возведенное в cтепень равную числу B = " + GetResult (numA, numB));