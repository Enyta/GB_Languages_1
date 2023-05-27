// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// Random rand = new Random();
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = rand.Next(-100, 101);
//     Console.Write($"{numbers[i]}, ");
// }
// int sum = 0;
// for (int i = 1; i < numbers.Length; i += 2)
// {
//     sum += numbers[i];
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int a = 1; a < numbers.Length; a+=2)
    sum  += numbers[a];

    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,101);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}