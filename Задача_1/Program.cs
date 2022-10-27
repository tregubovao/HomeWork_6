// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// y = k1 * x + b1
// y = k2 * x + b2
// Известны: b1, k1 и b2, k2

// y-y = k1 * x + b1 - (k2 * x + b2) (вычитаем из первого уравнения второе)
// y = k2 * x + b2

// y-y = k1 * x + b1 - k2 * x - b2     //   x * (k1 - k2) = (b2 -b1) 
// y = k2 * x + b2

// x = (b2 - b1) / (k1 - k2)
// y = k2 * x + b2

Console.Write("Введите b1: ");
float b1 = float.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k1: ");
float k1 = float.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите b2: ");
float b2 = float.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите k2: ");
float k2 = float.Parse(Console.ReadLine() ?? "0");

float x;
float y;
if(k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают"); 
else
 
    if(k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else 
    {   
        x = (b2 - b1) / (k1 - k2);
        y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
    }

