// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Number = {num}");
int firstDigit = num / 100;
int secondDigit = num % 10;
int threeDigit =num / 0.01;

Console.WriteLine($"num 1 = {firstDigit}");
Console.WriteLine($"num 2 = {secondDigit}");
Console.WriteLine($"num 3 = {threeDigit}");

//int FindMaxNumber(int num)
//{
//    int firstDigit = num / 10;
//    int secondDigit = num % 10;
//    return firstDigit > secondDigit ? firstDigit : secondDigit;
//}