﻿/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше или равна 3 символа.
*/

string[] array1 = new string[3] {"1234", "157", "-2"};
string[] array2 = new string[array1.Length];
void ToFillSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
ToFillSecondArray(array1, array2);
PrintArray(array2);



