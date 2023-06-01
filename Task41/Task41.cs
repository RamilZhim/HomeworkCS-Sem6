// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 30

Console.Write("Введите произвольные целые числа через запятую: ");
int[] inputArray = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);

int numbers = 0;

int NumsMoreThanZero(int numbers)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] > 0)
            numbers++;
    }
    return numbers;
}

Console.Write($"{string.Join(", ", inputArray)}; чисел больше нуля -> {NumsMoreThanZero(numbers)}");

