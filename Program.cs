// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] RandomArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)
            Console.Write($"[ {array[i]} ");
        else if (i == array.Length - 1)
            Console.WriteLine($"{array[i]} ]");
        else
            Console.Write($"{array[i]} ");
    }
}

int EvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        int a = array[i] / 100;
        int z = array[i] % 100;
        int b = z / 10;
        int c = array[i] % 10;
        if(a % 2 == 0)
        {
            count++;
        }
        if(b % 2 == 0)
        {
            count++;
        }
        if(c % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input lenght array: ");
int[] array = RandomArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(array);
int count = EvenNumber(array);
Console.WriteLine($"Count even number \"{count}\" in array lenght \"{array.Length}\"");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] RandomArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-30, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)
            Console.Write($"[ {array[i]} ");
        else if (i == array.Length - 1)
            Console.WriteLine($"{array[i]} ]");
        else
            Console.Write($"{array[i]} ");
    }
}

int SumElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

Console.Write("Input lenght array: ");
int[] array = RandomArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(array);
int count = SumElements(array);
Console.WriteLine($"Sum of \"{count}\" elements in odd positions");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
double[] RandomArrayDouble(int sizeArray)
{
    Random random = new Random();
    double[] array = new double[sizeArray];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100) + random.NextDouble();
    }
    return array;
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0)
            Console.Write($"[ {array[i]} ");
        else if (i == array.Length - 1)
            Console.WriteLine($"{array[i]} ]");
        else
            Console.Write($"{array[i]} ");
    }
}
void FindMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
        if(max < array[i])
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Array min: {min} and max {max} elements.");
}

Console.Write("Input lenght array: ");
double[] array = RandomArrayDouble(Convert.ToInt32(Console.ReadLine()));
PrintArray(array);
FindMinMax(array);
*/