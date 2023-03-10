using System;
using static System.Console;
Clear();
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Write(output);
    return int.Parse(Console.ReadLine()!);
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}