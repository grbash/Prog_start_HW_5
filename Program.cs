// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Task 36:");
Console.WriteLine();

int[] CreateArray(int arrLenght)
{
    int[] arr = new int[arrLenght];
    for (int i = 0; i < arrLenght; i++)
        arr[i] = new Random().Next(0, 1000);

    return arr;
}

int SumOfOddElems(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
        sum += arr[i];

    return sum;
}

Console.Write("Enter the number of array elements: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(arrLenght);
int res = SumOfOddElems(arr);

Console.WriteLine($"Number of even elements in the array - {res}");