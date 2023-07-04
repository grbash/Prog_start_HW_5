// Допущение для всех задач: Пользователь вводит адекватные значение 
// (если в условии задачи написано "возводит число A в натуральную степень B", то мы допускаем, 
// что число B на вход мы получим натуральное, а вот А может быть любое, иначе придется использовать слишком много проверок)

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Task 34:");
Console.WriteLine();

int[] CreateArray(int arrLenght)
{
    int[] arr = new int[arrLenght];
    for (int i = 0; i < arrLenght; i++)
        arr[i] = new Random().Next(100, 1000);

    return arr;
}

int EvenCount(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0) counter++;

    return counter;
}

Console.Write("Enter the number of array elements: ");
int arrLenght = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(arrLenght);
int res = EvenCount(arr);

Console.WriteLine($"Number of even elements in the array - {res}");