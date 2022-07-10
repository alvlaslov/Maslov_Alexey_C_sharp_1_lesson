/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/

Console.WriteLine ("Insert a number greater than 1: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 1)
{
    Console.WriteLine ("The number must be greater than 1 ");
}
else
{
int startnumber = 1;
for (int i = startnumber; i <= number; i++)
{
 if (i % 2 == 0) 
{
Console.Write(i + " ");
}
}
}