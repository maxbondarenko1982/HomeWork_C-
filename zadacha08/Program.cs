//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i;

    for (i = 2; i <= N; i = i+2)
{
     Console.WriteLine(i);
}
