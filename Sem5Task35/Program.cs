// ======================================================================
// #35 Задайте одномерный массив из 123 случайных чисел. Найдите 
// количество элементов массива, значения которых лежат в отрезке [10,99].
// Например: Пример для массива из 5, а не 123 элементов. 
// В своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// ======================================================================

// // Печать результата
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// //создаётся рандомный массив с заданными пользователем границами
// int[] FillArray(int length, int arrMin, int arrMax)
// {
//     //генератор случайных чисел
//     Random rnd = new Random();
//     //создаём массив
//     int[] array = new int[length];
//     if (arrMin < arrMax)
//     {
//         //заполняем массив
//         for (int i = 0; i < length - 1; i++)
//         {
//             array[i] = rnd.Next(arrMin, arrMax + 1); //+1 чтобы введённая пользователем верхняя граница входила в расчёт
//         }
//     }
//     return array;
// }

// //печатаем одномерный массив
// void Print1DArray(int[] array)
// {
//     Console.Write("[" + array[0] + ", ");
//     for (int i = 1; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1] + "]");
// }

// //считаем числа в массиве
// int CountElem(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (Test(array[i])) count++;//если эл-т массива соотв-т условию метода Тест
//     }
//     return count;
// }

// bool Test(int a) //вынесли отдельно проверку, в отдельный маленький метод
// {
//     return (a > 9 && a < 100);
// }

// int[] array = FillArray(123, 1, 1000);
// Print1DArray(array);
// PrintResult($"В массиве {CountElem(array)} элементов в отрезке [10;99]");


// Вариант решения ещё
// Универсальный метод генерации и заполнение массива
int[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

// подсчитывает количество элементов в отрезке
int CountElement(int[] array, int min, int max)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item >= min && item <= max)
            count++;
    }
    return count;
}
// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// вывод ответа
void PrintAnswer(int answer)
{
    Console.WriteLine("Колличество элементов в отрезке [10,99] -> {0}", answer);
}

int[] array = FillArray(123, 0, 800);
Print1DArray(array);
PrintAnswer(CountElement(array, 10, 99));