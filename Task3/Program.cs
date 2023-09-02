// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
Console.Write ("Enter first number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num%2 == 0)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");