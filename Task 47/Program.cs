Console.Clear();
System.Console.WriteLine("Введите размер массив m x n");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
double[,] array = new double[m,n];
Random rand = new Random();

for(int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++)
{
array[i,j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 3);
System.Console.Write(array[i,j] + "\t");
}
System.Console.WriteLine();
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


