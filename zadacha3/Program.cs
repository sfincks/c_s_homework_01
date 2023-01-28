// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число чтобы узнать чётное оно или нет");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number % 2 == 0)
{
    System.Console.WriteLine("Число четное");
}
else if (number % 2 == 1)
{
 System.Console.WriteLine("Число нечетное");   
}