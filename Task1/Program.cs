int [,] GenerateArray()
{

    int[,] array = new int[2,3];
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

void ElementPosition(int [,] array, int [] array2) 
{
    if ( array2[0] < array.GetLength(0) && array2[1] < array.GetLength(1))  
    {
        Console.Write($"ЭЛЕМЕНТ МАССИВА {array[array2[0],array2[1]]}");    
    }
        else 
        {
                Console.Write("Такого элемента не сущестует");
        }   
}

int[] EnterNumbers() 
{
    Console.Write("Введите номер позиции массива через , ");
    string input = Console.ReadLine();
    string[] arrayNumbers = input.Split(",");
        int[] numbers = new int[arrayNumbers.Length];
    for(int i  = 0; i < arrayNumbers.Length; i++)
    {
        numbers[i] = Convert.ToInt32(arrayNumbers[i]);
    }
    return numbers;
}

int[,] mass = GenerateArray();
PrintArray(mass); 
int [] mass1 = EnterNumbers(); 
ElementPosition(mass,mass1);
