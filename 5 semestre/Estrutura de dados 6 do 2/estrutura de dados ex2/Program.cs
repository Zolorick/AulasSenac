﻿int[] num = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,41,15,16,17,18,19,20};

Console.WriteLine(num.Length);

for (int i = num.Length; i > 0; i--)
{
    Console.Write(num[i -1]);
}
