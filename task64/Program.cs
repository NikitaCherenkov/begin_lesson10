// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N в обратном порядке. M = 1; N = 5. -> «5, 4, 3, 2, 1»

Console.WriteLine("Введите значение M и N через пробел");
int[] entry = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write($"M = {entry[0]}; N = {entry[1]}. -> ");
if (entry[0] >= entry[1]) Console.Write(Print(entry[0], entry[1]));
if (entry[1] > entry[0]) Console.Write(Print(entry[1], entry[0]));

string Print(int max, int min)
{
    string output = "«";
    for (int i = max; i >= min; i--)
    {
        output += $"{Convert.ToString(i)}";
        if (i > min) output += ", ";
    }
    output += "»";
    return output;
}
