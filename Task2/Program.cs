/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/

Console.WriteLine ("insert first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Insert second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"{number1} > {number2}");
}
else
{
    Console.WriteLine($"{number2} > {number1}");
}