// Time complexity: O(n), Space complexity: O(n)


int[] arr1 = { 1, 3, 5, 7 };
int[] arr2 = { 2, 4, 6, 8 };
int[] result = MergeSortedArrays(arr1, arr2);
Console.WriteLine(string.Join(", ", result)); 

int[] MergeSortedArrays(int[] arr1, int[] arr2)
{
    int arr1Counter = 0;
    int arr2Counter = 0;
    int resultCounter = 0;
    int[] result = new int[arr1.Length + arr2.Length];
    while (arr1Counter < arr1.Length && arr2Counter < arr2.Length)
    {
        if (arr1[arr1Counter] < arr2[arr2Counter])
        {
            result[resultCounter] = arr1[arr1Counter];

            arr1Counter++;
        }
        else
        {
            result[resultCounter] = arr2[arr2Counter];

            arr2Counter++;
        }
        resultCounter++;
    }

    while (arr1Counter < arr1.Length)
    {
        result[resultCounter] = arr1[arr1Counter];
        arr1Counter++;
        resultCounter++;
    }

    while (arr2Counter < arr2.Length)
    {
        result[resultCounter] = arr2[arr2Counter];
        arr2Counter++;
        resultCounter++;
    }

    return result;
}
