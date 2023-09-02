// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
Console.Write ("Enter first number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine ("Enter second number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.WriteLine ("Enter third number: ");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine(num1);
    }
}
else if (num2 > num1)
if (num2 > num3)
    {
        Console.WriteLine(num2);
    }
else Console.WriteLine(num3);