using System;
using System.Net.NetworkInformation;

{
    int n1 = 0, n2 = 1, n3, i;

    int[] fibonacci = new int[25];

    fibonacci[0] = n1;
    fibonacci[1] = n2;

    for(i=2; i < 25; ++i)
    {
        n3 = n1 + n2;
        fibonacci[i] = n3;
        n1 = n2;
        n2 = n3;
    }

    for (i = 0; i < 25; i++)
    {
        Console.WriteLine("Fibonacci number ("+ i +") = " + fibonacci[i]);
    }
}