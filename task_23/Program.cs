// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N = Prompt("Введите чис/ло: ");
Console.Write($"{N} --> ");
CubeTable(N);


int Prompt(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void CubeTable(int number)
{
    if (number >= 0)
    {
        if (number == 0)
        {
            Console.Write("0");
        }
        else
        {
            int i = 1;
            while (i < number)
            {
                int cube = Convert.ToInt32(Math.Pow(i, 3));
                Console.Write($"{cube}, ");
                i++;
            }
            Console.Write(Math.Pow(i, 3));
        }
    }
    if (number < 0)
    {
        int i = -1;
        while (i > number)
            {
                int cube = Convert.ToInt32(Math.Pow(i, 3));
                Console.Write($"{cube}, ");
                i--;
            }
            Console.Write(Math.Pow(i, 3));
    }
}
