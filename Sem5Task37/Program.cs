// ======================================================================
// #37 Найдите произведение пар чисел в одномерном массиве. Парой 
// считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// Например: [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21
// ======================================================================


//создаётся рандомный массив с заданными пользователем границами
int[] FillArray(int length, int arrMin, int arrMax)
{
    //генератор случайных чисел
    Random rnd = new Random();
    //создаём массив
    int[] array = new int[length];
    if (arrMin < arrMax)
    {
        //заполняем массив
        for (int i = 0; i < length - 1; i++)
        {
            array[i] = rnd.Next(arrMin, arrMax + 1); //+1 чтобы введённая пользователем верхняя граница входила в расчёт
        }
    }
    return array;
}

//печатаем одномерный массив
void Print1DArray(int[] array)
{
    Console.Write("[" + array[0] + ", ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

//создаём новый пересчитанный массив
int[] Change(int[] array)
{
    int[] outArr = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        outArr[i] = array[i] * array[array.Length - 1 - i]; //новый массив заполняем
    }
    return outArr;
}

int[] array = FillArray(12, 1, 10);
Print1DArray(array);
Print1DArray(Change(array));

// // Ещё один вариант решения
// // Универсальный метод генерации и заполнение массива
// int[] FillArray(int length, int topBorder, int downBorder)
// {
//     Random rand = new Random();
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(topBorder, downBorder + 1);
//     }
//     return array;
// }

// // подсчитывает произведение пар чисел в одномерном массиве
// int[] MultiOfPairsOfNumbers(int[] array)
// {
//     int[] outArray = new int[(int)array.Length / 2];
//     for (int i = 0; i < outArray.Length; i++)
//     {
//         outArray[i] = array[i] * array[array.Length - i - 1];
//     }
//     return outArray;
// }
// // вывод массив
// void Print1DArray(int[] array)
// {
//     Console.WriteLine("[{0}]", string.Join(", ", array));
// }


// int[] array = FillArray(7, 0, 30);
// Print1DArray(array);
// Print1DArray(MultiOfPairsOfNumbers(array));