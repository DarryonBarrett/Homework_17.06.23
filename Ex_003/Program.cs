// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
     return num;
}

int num = InputNum("Введите некоторое число N:");

for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if (i != num)
    System.Console.Write(", ");
    else
    System.Console.Write(".");
}
