// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Prompt("Введите координату x1: ");
int y1 = Prompt("Введите координату y1: ");
int z1 = Prompt("Введите координату z1: ");
int x2 = Prompt("Введите координату x2: ");
int y2 = Prompt("Введите координату y2: ");
int z2 = Prompt("Введите координату z2: ");
double distance = FindCube(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) --> {distance}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double FindCube(int xa, int ya, int za, int xb, int yb, int zb)
{
    double rasst = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    rasst = Math.Round(rasst, 2);
    return rasst;
}