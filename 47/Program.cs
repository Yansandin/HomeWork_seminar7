double[,] GenerateArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=random.NextDouble()*10-10;
            
        }
        
    }
    return array;
}

void PrintArray(double [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
            
        }
        Console.WriteLine();
    }
}

var array = GenerateArray(3,4, -10, 10);
PrintArray(array);
