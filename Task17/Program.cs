// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.
Console.Write("Введите номер четверти: ");
int a = int.Parse (Console.ReadLine ()!);
if (a>4||a<1)
{Console.WriteLine ("Указанного номера четверти не существует");}
else if (a==1)
{
Console.WriteLine ("x>0, y>0");
} 
else
if (a==2)
{Console.WriteLine ("x<0, y>0");}
else
if (a==3)
{Console.WriteLine ("x<0, y<0");}
else
if (a==4)
{Console.WriteLine ("x>0, y<0");
}