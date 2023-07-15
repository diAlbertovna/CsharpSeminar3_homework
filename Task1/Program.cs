// /Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



double Lenght(int x1, int y1, int z1,int x2, int y2, int z2)
{
    double abPoint = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return abPoint;
}

int GetInfo(string message)
{
    Console.Write(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


int x1Point = GetInfo("Enter coordinate x1 : ");
int y1Point = GetInfo("Enter coordinate y1 : ");
int z1Point = GetInfo("Enter coordinate z1 : ");
int x2Point = GetInfo("Enter coordinate x2 : ");
int y2Point = GetInfo("Enter coordinate y2 : ");
int z2Point = GetInfo("Enter coordinate z2 : ");
Console.WriteLine($"{Lenght(x1Point, y1Point, z1Point, x2Point, y2Point, z2Point)}");