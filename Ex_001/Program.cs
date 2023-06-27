// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNum()
{
    Console.Write("Введите пятизначное число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void FindPalind(int num)
{
    if ((num / 10000) == (num % 10) && (num / 1000 % 10) == (num / 10 % 10))
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом");
    }
}

int number = InputNum();
FindPalind(number);
