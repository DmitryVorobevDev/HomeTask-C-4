// Напишите программу, которая задает массив из 8 элеиентов и выводит их на экран;
Console.WriteLine ("Программа задает массив из 8 элементов и выводит его на экран");
int [] GetArray()
{
    int [] arr = new int [8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-19,20);
    }
    return arr;
}

int [] array = GetArray();
Console.WriteLine(String.Join(" | ", array));