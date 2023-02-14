double[,] create_array(int row, int column)
{
double[,] array = new double[row,column];
Random random = new Random();
for(int i=0;i<row;i++)
{
    for(int j=0;j<column;j++)
    {
        //RandomObj.NextDouble() * (end - begin) + begin
        array[i,j] = random.NextDouble() * (10 - 1) + 1;
        
    }
}
return array;
}

void print_array(double[,] array)
{
for(int i=0;i<array.GetLength(0);i++)
{
    for(int j=0;j<array.GetLength(1);j++)
    {
        Console.Write($"\t {array[i,j]} ");
    }
    Console.WriteLine();
}
}

Console.WriteLine("Введите число строк двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = create_array(m,n);
print_array(array);


