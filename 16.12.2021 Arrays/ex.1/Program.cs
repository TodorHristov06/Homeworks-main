﻿var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sum = 0;
foreach (var i in arr)
{
    sum += i;
}

Console.WriteLine(sum);