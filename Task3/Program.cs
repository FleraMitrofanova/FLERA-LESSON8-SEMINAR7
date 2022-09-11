int[,] Create2dArray(int rows, int columns, int min, int max)
{
int[,] newArray = new int[rows,columns];

for(int i=0; i < rows; i++)
{
    for(int j=0; j < columns; j++ )
    {
        newArray[i,j] = new Random().Next(min,max+1);
    }
}
return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }           
        Console.WriteLine();
    }
}

void GetAvgElements(int[,] array)
{
float avg =0;
float sum = 0;

  for(int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
                sum+=array[j,i];
                avg=sum/(array.GetLength(1));
        }
        Console.WriteLine("Среднее арифметическое равно " + Math.Round(avg,1));
        avg=0;
        sum=0;
        }
                
}

Console.Write("Input numbers of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min variable");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max variable");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2dArray(m,n,min,max);
Show2dArray(array);
GetAvgElements(array);


