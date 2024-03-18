

static int AveArr(int[] array)
{
    int sum = 0;
    for(int j = 0;j<array.Length;j++)
    {
        sum += array[j]; 
    }

    return sum/array.Length;
}