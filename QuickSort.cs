static void QuickSort(int[] array, int startIndex, int endIndex)
{
    if (endIndex - startIndex < 1)
    {
        return;
    }
    //1.length/2 as pivot, move it to last
    int pivotIndex = startIndex + (endIndex - startIndex + 1) / 2;
    int pivot = array[pivotIndex];
    int temp = array[pivotIndex];
    array[pivotIndex] = array[endIndex];
    array[endIndex] = temp;

    //2.move values smaller then pivot to left, then swap pivot to append
    var storeIndex = startIndex;
    for (var i = startIndex; i < endIndex; i++)
    {
        if (array[i] < pivot)
        {
            temp = array[i];
            array[i] = array[storeIndex];
            array[storeIndex] = temp;
            storeIndex++;
        }
    }
    temp = array[endIndex];
    array[endIndex] = array[storeIndex];
    array[storeIndex] = temp;

    //3. sort left and right
    QuickSort(array, startIndex, storeIndex - 1);
    QuickSort(array, storeIndex + 1, endIndex);
}