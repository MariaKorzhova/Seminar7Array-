Console.Clear();
System.Console.WriteLine("Введите размер массива m x n");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
int[,] NewArray = FillArrayAndPrint(m,n);

System.Console.WriteLine("Введите индексы необходимого элемента массива");
int i = inputNumber("i = ");
int j = inputNumber("j = ");
Element(NewArray, i, j);


void Element(int[,] NewArray, int i, int j)
{
    if (i < NewArray.GetLength(0) && j < NewArray.GetLength(1))
    {
        System.Console.WriteLine(NewArray[i,j]);
    }
    else
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
}



int[,] FillArrayAndPrint(int m, int n)
{
    int[,] array = new int[m,n];
    Random rand = new Random();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(-10, 10);
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
