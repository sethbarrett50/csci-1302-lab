namespace CS1302.Lab15.Sorting.Models;

public static class Sorter
{
    public static void BubbleSort(int[] values)
    {
        for (int i = 0; i < values.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < values.Length - 1 - i; j++)
            {
                if (values[j] > values[j + 1])
                {
                    int temp = values[j];
                    values[j] = values[j + 1];
                    values[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }

    public static void SelectionSort(int[] values)
    {
        for (int i = 0; i < values.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < values.Length; j++)
            {
                if (values[j] < values[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int temp = values[i];
                values[i] = values[minIndex];
                values[minIndex] = temp;
            }
        }
    }
}
