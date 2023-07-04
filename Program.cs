// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Task 36:");
Console.WriteLine();

double[] CreateArray(int arrLenght)
{
    double[] arr = new double[arrLenght];
    for (int i = 0; i < arrLenght; i++)
        arr[i] = new Random().NextDouble() * 10;

    return arr;
}

double DiffOfMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    return max - min;
}

Console.Write("Enter the number of array elements: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArray(arrLenght);
double res = DiffOfMinMax(arr);

Console.WriteLine($"Number of even elements in the array - {res}");