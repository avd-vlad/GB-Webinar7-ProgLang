/*-----------------------------------------------------------------------------------------
Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: Aij = i+j. Выведите полученный массив на экран.
-----------------------------------------------------------------------------------------*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = i+j;
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

int[,] newArr = CreateRandom2dArray();
Show2dArray(newArr);