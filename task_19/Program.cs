// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Prompt("Введите пятизначное число");
PalindromeOrNo(number);

int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    if (result > 9999 & result < 100000)
    {
        return result;
    }
    else
    {
        result = 0;
        return result;
    }

}

void PalindromeOrNo(int num)
{
    if (num / 10000 == num % 10 & num % 10000 / 1000 == num % 100 / 10 & num != 0)
    {
        Console.WriteLine($"{num} --> да");
    }
    else
    {
    if (num == 0)
        {
            Console.WriteLine("Ошибка: введённое число не пятизначное");
            return;
        }
    Console.WriteLine($"{num} --> нет");
    }
}