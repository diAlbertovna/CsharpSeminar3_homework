// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Numbers(int num)
{
    Console.Write($"{num} -> ");
    for( int numNew = 1; numNew < num; numNew++ )
    {
          Console.Write(Math.Pow(numNew, 3)  + ","); //Math.Pow(x2, 2)
    }
    Console.Write(Math.Pow(num, 3)  + ".");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
   
int num = GetInfo("Enter number: ");
Numbers(num);