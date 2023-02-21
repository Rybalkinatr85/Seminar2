//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// int a = new Random().Next(2)

int n = 8; 
int[] arr = new int[8]; 
Random rand = new Random(); 
for (int i = 0; i < arr.Length; i++) 
{ 
    arr[i] = rand.Next(2); 
} 
Console.WriteLine(string.Join(", ", arr));