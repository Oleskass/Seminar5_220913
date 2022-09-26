// ======================================================================
// #32 Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// Пример: [-4, -8, 8, 2] -> [4, 8, -8, -2]
// ======================================================================

// //чтение данных пользователя
// int ReadData(string line)
// {
//     //выводим сообщение
//     Console.WriteLine(line);
//     //считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     //возвращаем значение
//     return number;
// }

// //создаётся рандомный массив с заданными пользователем границами
// int[] FillArray(int length, int downBorder, int topBorder)
// {
//     //генератор случайных чисел
//     Random rnd = new Random();
//     //создаём массив
//     int[] array = new int[length];
//     if (downBorder < topBorder)
//     {
//         //заполняем массив
//         for (int i = 0; i < length - 1; i++)
//         {
//             array[i] = rnd.Next(downBorder, topBorder + 1); //+1 чтобы введённая пользователем верхняя граница входила в расчёт
//         }
//     }
//     return array;
// }

// //печатаем одномерный массив
// void Print1DArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
// }

// //изменяем массив
// int[] InverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     }
//     return array;
// }

// int length = ReadData("Введите длину массива: ");
// int downBorder = ReadData("Введите минимальное значение: ");
// int topBorder = ReadData("Введите максимальное значение: ");

// int[] array =  FillArray(length, downBorder, topBorder);
// Print1DArray(array);
// Print1DArray(InverseArray(array));

// Ещё один вариант решения
// Генерация случайного массива.
int[] GenArr(int arrLen, int arrMin, int arrMax)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();

    if (arrMin > arrMax) //если мин больше макс, то меняем их местами
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax);
    }
    return arr;
}

// Печать массива
void PrintArr(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]"); //встроенная функция, метод Джоин у класса стринг. Доллар значит что внутри будет содержаться исполняемый код, и тогда он смотрит в фигурные скобки.
}

int[] InverseArray2(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int[] arr = GenArr(10, 5, -5);
PrintArr(arr);

int[] res = InverseArray2(arr);
PrintArr(res);