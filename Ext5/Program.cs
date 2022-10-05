// 

int[] array = { 20, 12, 24, 28, 47, 75, 86, 67, 28 };

int n = array.Length;
int find = 28;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}

