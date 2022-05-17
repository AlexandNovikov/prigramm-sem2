// напишите программу, которая по заданному 
// номеру четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y)
//         ^
//      2  |   1
//         |
// --------+--------
//         |
//     3   |   4


Console.WriteLine("введите номер диапазона(от 1 до 4): ");
int range = Convert.ToInt32(Console.ReadLine());
if (range == 1)
{
    Console.WriteLine("для диапазона " + range + ", диапазон возможных координат: x > 0  y > 0");
}
else if (range == 2)
{
    Console.WriteLine("для диапазона " + range + ", диапазон возможных координат: x > 0  y < 0");
}
else if (range == 3)
{
    Console.WriteLine("для диапазона " + range + ", диапазон возможных координат: x > 0  y > 0");
}
else if (range == 4)
{
    Console.WriteLine("для диапазона " + range + ", диапазон возможных координат: x < 0  y > 0");
}
else if (range > 4 || range < 1)
Console.WriteLine("Такого диапазона не существет");