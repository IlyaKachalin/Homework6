// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

try
{

    Console.Write("Введите количество вводимых чисел (М). М = ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];

    int[] Array(int m)
    {
        for (int i = 0; i < m; i++)
        {
            Console.Write("Введите число: ");
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("Вводимый массив: [" + string.Join(", ", array) + "]");
        return array;
    }

    int Count(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) count++;
        }
        return count;
    }

    Array(m);
    int result = Count(array);
    Console.WriteLine($"Количество положительных чисел = {result}");
}

catch
{
    Console.WriteLine("Введите целое число");
}
