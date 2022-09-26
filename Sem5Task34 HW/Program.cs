// ========================================================================
// №34 Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в 
// массиве. Например: [345, 897, 568, 234] -> 2; [845, 222, 367, 123] -> 1
// * Отсортировать массив методом пузырька
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

//генерация массива
int[] RandomArr(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

//проверка на чётные числа
int EvenCount(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    return evenNum;
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
//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//сама программа

//PrintResult("Чётных чисел в массиве: " + EvenCount((RandomArr(ReadData("Введите длину массива: "))))); //программа в одну строку, но не показываем, какой массив создали. Всё из-за метода Print1DArray

int length = ReadData("Введите длину массива: "); //запрашиваем данные от пользователя

int[] array = RandomArr(length); //создаём массив
Print1DArray(array); //печатаем массив, просто чтобы посмотреть
int evenNum = EvenCount(array); //считаем кол-во чётных эл-тов массива
PrintResult("Чётных чисел в массиве: " + evenNum); //выводим рез-т



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

// //генерация массива и проверка на чётные числа
// string RandomArr(int length)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();

//     int evenNum = 0;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = rnd.Next(100, 1000);
//         if (array[i] % 2 == 0)
//         {
//             evenNum++;
//         }
//     }
//     return (string.Join(", ", array) + "\nЧётных чисел в массиве: " + evenNum);
// }

// //вывод результата
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// //сама программа
// PrintResult(RandomArr(ReadData("Введите длину массива: ")));
