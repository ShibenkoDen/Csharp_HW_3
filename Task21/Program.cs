/*
Задача 20. Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
А (3,6,8); В (2,1,-7) -> 15.84
А (7,-5,0); В (1,-1,9) -> 11.53
*/


Console.Clear();
double GetUserValue(string message)
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine()!);
    return result;
}

double getDistance (double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double distance = Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2));
    return distance;
}

double Ax = GetUserValue ("Введите координату Х точки А");
double Ay = GetUserValue ("Введите координату Y точки А");
double Az = GetUserValue ("Введите координату Z точки А");
double Bx = GetUserValue ("Введите координату Х точки B");
double By = GetUserValue ("Введите координату Y точки B");
double Bz = GetUserValue ("Введите координату Z точки B");

double distance = Math.Round(getDistance (Ax, Ay, Az, Bx, By, Bz), 2);
Console.WriteLine ($"Расстоние между точкой А ({Ax},{Ay},{Az}) и точкой В ({Bx},{By},{Bz}) равно {distance}");