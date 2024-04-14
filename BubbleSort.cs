static void BubbleSort(int[] array)
{
    if (array.Length < 2) return;
    for (var i = 1; i <= array.Length; i++)
    {
        for (var j = 0; j < array.Length - i; j++)
        {
            if (j + 1 < array.Length && array[j] > array[j + 1])
            {
                var temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}