// нахождение максимума из 9ти чисел. клучшенное применение метода

int a1 = 76;
int b1 = 167;
int c1 = 23;
int a2 = 89;
int b2 = 4467;
int c2 = 45;
int a3 = 44;
int b3 = 56799;
int c3 = 24;

int Max(int arg1,int arg2, int arg3)
{
    int result = arg1;
    if (result<arg2) result = arg2;
    if (result<arg3) result = arg3;
    return result;
}
int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);