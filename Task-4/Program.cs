/*-----------------------------------------------------------------------------------------
Найдите строку с наименьшей суммой элементов в двумерном массиве
-----------------------------------------------------------------------------------------*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = new Random().Next(min, max);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();

    }
    Console.WriteLine();

}

int FindMinRowSum(int[,] arr)
{
    int rowNum = 0;
    int minSumRow =0;
    int sumRow = 0;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        sumRow = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
            sumRow += arr[i,j];
        if(i==0)
            minSumRow=sumRow;
        else
            if(sumRow<minSumRow)
            {
                minSumRow=sumRow;
                rowNum = i;
            }
    }
    return rowNum;
}

int[,] newArr = CreateRandom2dArray();

Show2dArray(newArr);
Console.WriteLine($"The row with minimum elements sum is: {FindMinRowSum(newArr)}");