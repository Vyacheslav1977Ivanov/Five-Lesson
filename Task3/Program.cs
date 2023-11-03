int [,] GenerateArray()
{

    int[,] array = new int[10,10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}        

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SummStringArrayCheck(int [,] array)
{
    int [] summ = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ[i] = summ[i] + array[i,j];
            

        }
        Console.WriteLine($"Cумма cтроки №{i} = {summ[i]} ");
    }
    int min = summ[0];
    int IndexMin = 0;
    for(int i = 0; i < summ.Length ; i++)
    {
        if(summ[i] < min )
        {
            min = summ[i];
            IndexMin = i;
        }
    }
    Console.WriteLine($"Номер строки с минимальной суммой - №{IndexMin}");
}

int[,] arr = GenerateArray();
PrintArray(arr);
SummStringArrayCheck(arr);
