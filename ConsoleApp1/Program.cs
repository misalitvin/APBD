

static int AveArr(int[] array)
{
    int sum = 0;
    for(int k = 0;k<array.Length;k++)
    {
        sum += array[k];
    }

    return sum/array.Length;
}