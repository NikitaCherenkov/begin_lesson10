// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M и N через пробел");
int[] entry = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write($"M = {entry[0]}; N = {entry[1]}. -> ");
Console.Write(Calc(entry[0], entry[1]));

int Calc(int a, int b)
{
    int c = 0;
    int n = 0;
    if (a > b)
    {
        for (int i = b; i <= a; i++)
        {
            c += b + n;
            n++;
        }
        return c;
    }
    else
    {
        for (int i = a; i <= b; i++)
        {
            c += a + n;
            n++;
        }
        return c;
    }
}
