
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


 void FindElement(int[,] array)
{
      Console.WriteLine("Ведите поизции элемента строка/столбец: ");
      int x = Convert.ToInt32(Console.ReadLine());
      int y = Convert.ToInt32(Console.ReadLine());

      if(x+1>array.GetLength(0)||y+1>array.GetLength(1))
     Console.WriteLine("Такого числа нет в массиве");
      else 
    Console.WriteLine(array[x,y]);
}


int[,] array = GenerateArray(3, 4, -10, 10);
PrintArray(array);
FindElement(array);