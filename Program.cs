// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();
int[,,] arrr = new int[2, 2, 2];
FilArray(arrr);
PrintArray(arrr);
WriteLine();


void FilArray(int[,,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
            for (int k = 0; k < ar.GetLength(2); k++)
                ar[i, j, k] = new Random().Next(1, 99);
    }
}


void PrintArray(int[,,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)

            for (int k = 0; k < ar.GetLength(2); k++) WriteLine($"{ar[i, j, k]} ({i},{j},{k})");
    }
    WriteLine();
}