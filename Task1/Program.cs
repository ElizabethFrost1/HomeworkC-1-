// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
Console.Write ("Enter first number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine ("Enter second number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else Console.WriteLine(num2);