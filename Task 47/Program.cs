Console.Clear();
System.Console.WriteLine("Введите размер массив m x n");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
double[,] NewArray = FillArrayAndPrint(m,n);


double[,] FillArrayAndPrint(int m, int n)
{
    double[,] array = new double[m,n];
    Random rand = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 3);
            System.Console.Write(array[i,j] + "\t");
        }
    System.Console.WriteLine();
    }
    return array;
}



int inputNumber(string str)
{
int number;
string text;

while (true)
{
System.Console.Write(str);
text = Console.ReadLine();
if (int.TryParse(text, out number))
{
break;
}
System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}


