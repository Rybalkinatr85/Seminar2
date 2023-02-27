// Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//Заполняю массив случайными числами от 100 до 999

int[] GetBinArray(int n)
{
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100,1000);
}
return array;
}
int EvenNumbers(int[] array)
{
int count = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0)
{
count++;
}
}
return count;
}
Console.Clear();
int[] mas = GetBinArray(10);
Console.WriteLine($"Исходный массив: [{string.Join(", ", mas)}]");
int rezult = EvenNumbers(mas);
Console.WriteLine($"Четных чисел в массиве = {rezult}");