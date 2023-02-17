// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.Console.Clear();
Console.WriteLine("Введите координату X для точки a");
double Xa = double.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки a");
double Ya = double.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Z для точки a");
double Za = double.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату X для точки b");
double Xb = double.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Y для точки b");
double Yb = double.Parse (Console.ReadLine()!);
Console.WriteLine("Введите координату Z для точки b");
double Zb = double.Parse (Console.ReadLine()!);
double s = Math.Sqrt(Math.Pow((Xa-Xb),2)+Math.Pow((Ya-Yb),2)+Math.Pow((Za-Zb),2));
Console.WriteLine(s);