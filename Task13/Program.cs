// Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine ());
if (n <=99||n<1)
{

Console.WriteLine("3-ей цифры не существует");

}

else 

{
  while (n>1000)
{

n/=10;

}
  Console.WriteLine(n%10);
}
