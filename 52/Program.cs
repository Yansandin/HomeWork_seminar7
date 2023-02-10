int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max + 1);

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
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
}


void FindArithmeticalAverage(int[,] array)
{
    double summ = 0;
    double result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {


            summ += array[i, j];
            

        

            
        }
        result= summ/array.GetLength(1);
        Console.WriteLine($"{result}");

    }
    
    

}

int[,] array = GenerateArray(4, 4, -10, 10);
PrintArray(array);
FindArithmeticalAverage(array);
