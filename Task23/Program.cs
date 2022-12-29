/*
Задача 23. Напишите программу, которая принимает на вход число (N) и выдает
таблицу кубов чисел от 1 до N
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();

int GetUserNumber (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetNumberCube (int Number)
{
    int cube = (int) Math.Pow (Number, 3);
    return cube;
}

int number = GetUserNumber("Введите число: ");
for (int i = 1; i <= number; i++)
{
    int res = GetNumberCube (i);
    Console.Write ($"{res} ");
}
Console.WriteLine();