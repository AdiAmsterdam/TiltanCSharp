//main
Console.WriteLine("Enter array length");
int arrayLength = int.Parse(Console.ReadLine());
int[] arr = CreateArray(arrayLength);
PrintArray(arr);
Console.WriteLine("Array Sum: " + ArraySum(arr));
Console.WriteLine("Array average: " + ArrayAverage(arr));
Console.WriteLine("Array Max: " + ArrayMax(arr));
MultiplyEveryThird(arr, 3);
PrintArray(arr);

int[] CreateArray(int n) //creates an array
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i;
    }
    return array;
}

void PrintArray(int[] array) //Prints the array
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int ArraySum(int[] array) //returns the summery of all numbers in the array
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

int ArrayAverage(int[] array)
{
    return ArraySum(array) / array.Length;
}

int ArrayMax(int[] array)// returns the max number in the array
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

void MultiplyEveryThird(int[] array, int multiplier) //multiplies every third number by a given multiplier
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 3 == 0 && i != 0)
        {
            array[i-1] *= multiplier;
        }
    }
}

float[] ArrayMerge(float[] array1, float[] array2) //Merges 2 float type arrays
{
    int sumLength = array1.Length + array2.Length;
    float[] newArray = new float[sumLength];
    for (int i = 0; i < array1.Length; i++)
    {
        CopyArray(newArray, array1, i);
    }

    for (int j = array1.Length; j < sumLength; j++)
    {
        CopyArray(newArray, array2, j);
    }
    return newArray;
}

void CopyArray(float[] copyTo, float[] copyFrom, int index) //copys the array according to index
{
    copyTo[index] = copyFrom[index];
}