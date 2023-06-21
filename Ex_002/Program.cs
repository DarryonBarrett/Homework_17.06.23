// Напишите программу, которая принимает на вход осидинаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNums(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    int X = xB - xA;
    int Y = yB - yA;
    int Z = zB - zA;
    double DotsX = Math.Pow(X, 2);
    double DotsY = Math.Pow(Y, 2);
    double DotsZ = Math.Pow(Z, 2);
    double sum = DotsX + DotsY + DotsZ;
    double AB = Math.Sqrt(sum);
    return AB;
}

int xA = InputNums("Введите точку A по оси x: ");
int yA = InputNums("Введите точку A по оси y: ");
int zA = InputNums("Введите точку A по оси z: ");
int xB = InputNums("Введите точку B по оси x: ");
int yB = InputNums("Введите точку B по оси y: ");
int zB = InputNums("Введите точку B по оси z: ");

double distance = Distance(xA, yA, zA, xB, yB, zB);
double distance2 = (Math.Round(distance, 2));
Console.WriteLine($"Расстояние между точками A и B - {distance2}");
