using System;
using static System.Console;
Clear();
int n = InputInt("Введите положительное число: ");
int m = 1;
WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Write(output);
    return int.Parse(ReadLine()!);
}