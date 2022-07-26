/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1. Выполнить с помощью рекурсии.
*/

Console.Clear();
Console.WriteLine("Натуральные числа в промежутке от N до 1");
Console.Write ("Задайте число N: ");
int num = int.Parse(Console.ReadLine());
NaturalNumber(num);
void NaturalNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);
}