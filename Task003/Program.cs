/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/


void FillgArrayofRealNumbers(double[] arrayRealNumbers, int min, int max)
{
    for (int i = 0; i < arrayRealNumbers.Length; i++ )
    {
        Random rand = new Random();
        arrayRealNumbers[i] = rand.Next(min * 100, max * 100)/100.0;
    }
}

double ArrayNumberDifference(double[] arrayRealNumbers)
{
    double maxNumber = arrayRealNumbers[0];
    double minNumber = arrayRealNumbers[0];

    for (int i = 1; i < arrayRealNumbers.Length; i++)
    {
        if (maxNumber < arrayRealNumbers[i])
        {
            maxNumber = arrayRealNumbers[i];
        }
           
        if (minNumber > arrayRealNumbers[i])
        {
            minNumber = arrayRealNumbers[i];
        }
    }

    double decision = (maxNumber - minNumber);
    return  decision;
}

void PrintArray(double[] arrayRealNumbers)
{
    int count = arrayRealNumbers.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(arrayRealNumbers[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


Console.Write("Задайте размер массива: N = ");

int length = Convert.ToInt32(Console.ReadLine());
double[] arrayRealNumbers = new double[length];

FillgArrayofRealNumbers(arrayRealNumbers, 10, 100);
PrintArray(arrayRealNumbers);
double decision = ArrayNumberDifference(arrayRealNumbers);

Console.WriteLine($"\nразница между между min и max элементами: {decision:F2}");