
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите 1 число: ");
int number_A = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int number_B = int.Parse(Console.ReadLine()!);

if(number_A >  number_B)
{
    Console.Write($"Максимальное число = {number_A}, минимальное число = {number_B}");
}
else
{
    Console.Write($"Максимальное число = {number_B}, минимальное число = {number_A}");
}