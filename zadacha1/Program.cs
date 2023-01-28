// Задача 2:
// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    System.Console.WriteLine("max = " + firstNumber + ", " + "min = " + secondNumber);
}
else
{
    System.Console.WriteLine("max = " + secondNumber + ", " + "min = " + firstNumber);
}