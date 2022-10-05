// нахождение максимума из 9ти чисел. клучшенное применение метода

int[] array = {20,12,24,35,47,75,86,67,28};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);