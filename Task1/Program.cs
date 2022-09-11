double[,] Create2dArray(int rows, int columns, double min, double max)
{
double[,] newArray = new double[rows,columns];

for(int i=0; i < rows; i++)
{
    for(int j=0; j < columns; j++ )
    {
        newArray[i,j] = new Random().NextDouble()*10;
    }
}
return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j],1)+" ");
        }           
        Console.WriteLine();
    }
}

Console.Write("Input numbers of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min variable");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input max variable");
double max = Convert.ToDouble(Console.ReadLine());

double[,] array = Create2dArray(m,n,min,max);
Show2dArray(array);