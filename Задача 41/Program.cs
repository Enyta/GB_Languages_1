// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// System.Console.WriteLine("Введите количество чисел: ");
// int NewMass = Convert.ToInt32(Console.ReadLine());

// int Positive = 0;

// for (int i = 0; i < NewMass; i++)
// {
//     Console.WriteLine($"Введите число {i + 1}: ");
//     int num = Convert.ToInt32(Console.ReadLine());

//     if (num > 0)
//         Positive++;
// }

// Console.WriteLine($"{Positive} положительных чисел.");
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество чисел: ");
int NewMass = Convert.ToInt32(Console.ReadLine());

int PositiveNums()
{
    int Positive = 0;
    for (int i = 0; i < NewMass; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Positive++;
    }
    return Positive;
}
Console.WriteLine($"Положительных чисел: {PositiveNums()}");