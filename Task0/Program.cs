// // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void Reverse(int num)
{
    if(num > 9999) 
    {
        int num1 = num / 10000 % 10;
        int num2 = num / 1000 % 10;
        int rev1 = num / 10 % 10;
        int rev2 = num % 10;
        if  (num1 == rev2 && num2 == rev1)
        {
            Console.Write("Palindrom");
        }
        else
        {
            Console.Write("No");
        }
    }    
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
   
}

int num = GetInfo("Enter number: ");
Reverse(num);

