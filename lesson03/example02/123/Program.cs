﻿int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[]array);
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
}

void SelectionSort(int[]array)
{
    for (int i=0; i < array.Length; i++);
    {
        int minPosition=i;
        for (int j = int+1; j < array.Lenght; j++)
        {
            if(array[j] < array[minPosition] 
            {
                minPosition = j;
            }
        }
    int temporary = array[i];
    array[i]=array[minPosition];
    array[minPosition] = temporary;
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
