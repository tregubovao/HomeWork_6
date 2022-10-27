// Написать программу масштабирования фигуры

int xa = 0; int ya = 0;
int xb = 0; int yb = 4;
int xc = 8; int yc = 4;
int xd = 8; int yd = 0;

Console.WriteLine();
Console.WriteLine($"Имеется прямоугольник АВСD с вершинами в координатах по оси x и оси y: ({xa};{ya}), ({xb};{yb}), ({xc};{yc}), ({xd};{yd}).");
Console.WriteLine();
Console.Write("Введите коэффициент масштабирования фигуры:  ");
float k = float.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Вершины нового  прямоугольника АВСD с учетом коэффициента масштабирования {k}: ({xa * k};{ya * k}), ({xb * k};{yb * k}), ({xc * k};{yc * k}), ({xd * k};{yd * k}).");

