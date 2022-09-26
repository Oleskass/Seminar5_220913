// ========================================================================
// №36 Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [3, 7, -2, 1] -> 8; [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю
// ========================================================================

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//генерация массива
int[] RandomArr(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

// //вычисление суммы нечётных позиций i++ и суммы нечётных чисел
// string OddSum(int[] array)
// {
//     int sumOdd = 0;
//     int oddPosition = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 0) //нечётные позиции массива (или чётные индексы массива) и их сумма
//         {
//             oddPosition += array[i];
//         }
//         if (array[i] % 2 != 0) //проверка на нечётность чисел и их сумма
//         {
//             sumOdd += array[i];
//         }
//     }
//     return (string.Join(", ", array) + "\nСумма нечётных чисел в массиве = " + sumOdd + "\nСумма чисел на нечётных позициях = " + oddPosition);
// }

//вычисление суммы нечётных позиций не i++, а i=i+2
string OddSumPlus2(int[] array)
{
    int oddPosition = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
            oddPosition += array[i];
    }
    return (string.Join(", ", array) + "\nСумма чисел на нечётных позициях = " + oddPosition);
}

//сама программа
//PrintResult(OddSum(RandomArr(ReadData("Введите длину массива: ")))); //i++
PrintResult(OddSumPlus2(RandomArr(ReadData("Введите длину массива: ")))); //i+=2

// Вариант 1 - замечание, что сделала всё в одном методе, надо разбить
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

// //вывод результата
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// //сама программа
// PrintResult(RandomArr(ReadData("Введите длину массива: ")));

// //генерация массива и проверка на нечётность чисел
// string RandomArr(int length)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();

//     int sumOdd = 0;
//     int oddPosition = 0;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = rnd.Next(0, 100);
//         if (i % 2 == 0) //нечётные позиции массива (или чётные индексы массива) и их сумма
//         {
//             oddPosition += array[i];
//         }
//         if (array[i] % 2 != 0) //проверка на нечётность чисел и их сумма
//         {
//             sumOdd += array[i];
//         }
//     }

//     return (string.Join(", ", array) + "\nСумма нечётных чисел в массиве = " + sumOdd + "\nСумма чисел на нечётных позициях = " + oddPosition);
// }