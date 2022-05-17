//Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

while (i <= number)
{

    {
        Console.WriteLine($"Число{i,10} | Квадрат{(int)(i * i),10}");

    }

    i++;
}

