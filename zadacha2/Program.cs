﻿// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    System.Console.WriteLine("max = " + firstNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    System.Console.WriteLine("max = " + secondNumber);
}
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    System.Console.WriteLine("max = " + thirdNumber);
}
