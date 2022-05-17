// написать программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними
// в 2D пространстве
// пример A (3, 6); B (2,1) ->5,09
//        A (7, -5); B( 1, -1) ->7,21

Console.WriteLine("Введите координаты первой точки ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("расстояние от первой до второй точки = ");

double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
double n = Math.Round(distance, 2); // преобразовывает и округляет до 2 занчения после запятой
Console.WriteLine(n);