// ======================================================================
// #33 Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// Например: 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
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
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine(array[array.Length - 1]);
// }

// //изменяем массив
// bool FindElem(int[] array, int elm)
// {
//     bool res = false; //можно через переменную так, а можно без неё, просто тогда вовращаем false в конце, а в if возвращаем true.
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == elm)
//         {
//             res = true;
//             break;
//         }
//     }
//     return res;
// }

// int length = ReadData("Введите длину массива: ");
// int downBorder = ReadData("Введите минимальное значение: ");
// int topBorder = ReadData("Введите максимальное значение: ");


// int[] array = FillArray(length, downBorder, topBorder);
// Print1DArray(array);
// int elm = ReadData("Какое число ищем? ");
// PrintResult(elm + " -> " + FindElem(array, elm));


// Ещё вариант решения
// Универсальный метод генерации и заполнение массива
int[] FillArray(int length,int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

// определяет является ли value элементом массива
bool Contains(int[] array, int value)
{
    foreach (int item in array)
    {
        if(item == value)
        return true;
    }
    return false;
}

// вывод массив
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// вывод ответа
void PrintAnswer(bool answer)
{
    Console.WriteLine(answer ? "Да" : "Нет"); //тернарный оператор
}


int[] array = FillArray(10, 0, 10);
Print1DArray(array);
Console.WriteLine("Ищем элемент: 8");
PrintAnswer(Contains(array, 8));