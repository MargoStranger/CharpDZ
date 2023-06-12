//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите 1 число: ");
int number_A = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int number_B = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 число: ");
int number_C = int.Parse(Console.ReadLine()!);
int max = 0;

if(number_A >  number_B)
{
    max = number_A;
}
else if(number_B >  number_C)
{
    max = number_B;
}
else if(number_C >  number_B)
{
    max = number_C;
}

Console.Write($"Максимальное число = {max}");