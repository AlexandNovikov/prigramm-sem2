// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.Write("Enter number A :");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B :");
int b = int.Parse(Console.ReadLine());
bool res = b == a * a || a == b * b;
Console.WriteLine(res ? "Да" : "Нет");
