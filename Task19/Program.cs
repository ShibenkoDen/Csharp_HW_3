/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет, 12821 -> да, 23432 -> да
*/

Console.Clear();

int GetUserNumber (string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


int Number = GetUserNumber ("Введите пятизначное число: ");
if ((Number < 100000 && Number > 9999) || (Number < -9999 && Number > - 100000))
{    
    int Digit5 = Number % 10; 
    int newNumber = Number / 10;
    int Digit4 = newNumber % 10;
    newNumber = newNumber / 100;
    int Digit2 = newNumber % 10;
    newNumber = newNumber / 10;
    int Digit1 = newNumber % 10;

    if (Digit1 == Digit5 && Digit2 == Digit4)
    {
        Console.WriteLine ($"Число {Number} является палиндромом.");
    }
    else 
    {
        Console.WriteLine ($"Число {Number} не палиндром");
    } 
}
else 
{
    Console.WriteLine ($"Число {Number} не пятизначное");
}