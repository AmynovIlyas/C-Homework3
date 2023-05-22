// 2-ой вариант решения 19 задачи
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int ReverseNumber(int a)
{
    int revNum = 0;
    int temp = a; // 12321
    while(temp > 0)
    {
        revNum = revNum * 10 + temp % 10; // 0 + 1 // 10 + 2 // 120 + 3 // 1230 + 1 
        temp /= 10; // 1232 // 123 // 12 // 1 // 0 
    }
    return revNum;
}

int a = Prompt("Введите 5-значное число: ");
int reversed = ReverseNumber(a);

if(a > 9999 && a < 100000)
{
    if(reversed == a)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Введенное число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Введенное число не является 5-значным"); 
}


