// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int size = 8;

Console.Write("Введите левую границу массива: ");
int leftRange = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите правую границу массива: ");
int rightRange = Convert.ToInt32(Console.ReadLine());

int[] nums = FillArray(size, leftRange, rightRange);

PrintArray(nums);

Console.ReadLine();


int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] nums = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(leftRange, rightRange);
    }
    return nums;
}
void PrintArray(int[] nums)
{
    Console.Write("[");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i]);
        if (i < nums.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}