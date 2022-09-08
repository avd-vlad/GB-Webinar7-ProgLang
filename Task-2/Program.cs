/*-----------------------------------------------------------------------------------------
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените 
эти элементы на их квадраты.
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
            newArray[i,j] = i+j;
    return newArray;
}
int[,] Update2dArray(int[,] arr)
{
    for(int i = 0; i< arr.GetLength(0); i+=2)
        for(int j = 0; j < arr.GetLength(0); j+=2)
            arr[i,j] = arr[i,j]*arr[i,j];
    return arr;
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

int[,] newArr=CreateRandom2dArray();

Show2dArray(newArr);
Update2dArray(newArr);
Show2dArray(newArr);
