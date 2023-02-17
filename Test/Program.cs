int Max (int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}
int a1=15;
int b1=30;
int c1=22;
int a2=23;
int b2=50;
int c2=60;
int a3=70;
int b3=71;
int c3=19;

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);

Console.WriteLine(max);