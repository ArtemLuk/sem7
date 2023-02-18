// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)    {
        for (int j = 0; j < n; j++)        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray){
    for (int i = 0; i < inArray.GetLength(0); i++)    {
        for (int j = 0; j < inArray.GetLength(1); j++)        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] Sum(int [,] array){
    double[] S = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)    {
        double Sr=0;
        for (int i = 0; i < array.GetLength(0); i++)        {
            Sr=Sr+array[i,j];
            }
        S[j]=Convert.ToDouble(Sr)/array.GetLength(0);
        }
    return S;
}

void PrintSum(double[] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]:f1} ");
    }
}

Console.Clear();
Console.WriteLine("Please enter row quantity "); 
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter column quantity "); 
int column = int.Parse(Console.ReadLine());
int [,] A = GetArray(row, column);
PrintArray(A);
double[] Result = Sum(A);
Console.WriteLine();
Console.WriteLine("The Sum array is: ");
PrintSum(Result);