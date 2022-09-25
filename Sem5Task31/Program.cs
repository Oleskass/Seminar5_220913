// ======================================================================
// #31 Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива.
// Например: в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.
// ======================================================================

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

//создаётся рандомный массив с заданными пользователем границами
int[] FillArray(int length, int downBorder, int topBorder)
{
    //генератор случайных чисел
    Random rnd = new Random();
    //создаём массив
    int[] array = new int[length];
    if (downBorder < topBorder)
    {
        //заполняем массив
        for (int i = 0; i < length - 1; i++)
        {
            array[i] = rnd.Next(downBorder, topBorder + 1); //+1 чтобы введённая пользователем верхняя граница входила в расчёт
        }
    }
    return array;
}

//печатаем одномерный массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int[] NegativeositiveSums(int[] array)
{
    int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sums[0] += array[i];
        }
        else
        {
            sums[1] += array[i];
        }
    }
    return sums;
}

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//сама программа
//собрали данные пользователя
int length = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите ерхнюю границу заполнения массива: ");
//заполнили массив
int[] inputArray = FillArray(length, downBorder, topBorder);
//напечатали массив
PrintArray(inputArray);
//посчитали кол-во полодительных и отрицательных
int[] sumArray = NegativeositiveSums(inputArray);
//вывели результат двумя способами
PrintResult("Сумма > 0: " + sumArray[0] + " Сумма < 0: " + sumArray[1]);
PrintArray(sumArray);

// //ещё один вариант решения, но это не структурное программирование, так как тут можно легко запутаться
// string RandomArr(int lng, int from, int to)
// {
//     int[] array = new int[lng];
//     Random rnd = new Random();

//     int sumNeg = 0;
//     int sumPos = 0;
//     for (int i = 0; i < lng; i++)
//     {
//         array[i] = rnd.Next(from, to + 1);
//         if (array[i] > 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }

//     return (string.Join(", ", array) + "\n " + sumPos + " " + sumNeg);
// }

// Console.WriteLine(RandomArr(12, -9, 9));