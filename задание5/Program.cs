Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

//double d = Math.Pow(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2), 0.5);

// double d = Math.Pow((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)), 0.5);

// double d = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine(d);
