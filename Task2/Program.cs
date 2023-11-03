int [,] GenerateArray()
{

    int[,] array = new int[3,3];
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

int[,] ReverseFirstAndLaststring(int [,] array)
{
    int number = 0;
    for(int j = 0;j < array.GetLength(1);j++) 
    {
        number = array[0,j];
        array[0,j] = array[array.GetLength(0) - 1,j]; 
        array[array.GetLength(0) - 1,j] = number;
    }
    return array;

}

int [,] mass = GenerateArray();
PrintArray(mass);
ReverseFirstAndLaststring(mass);
Console.WriteLine("-----------");
PrintArray(mass);
