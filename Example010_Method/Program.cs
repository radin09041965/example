﻿int[] array = {16, 54, 73, 54, 655, 76};

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}