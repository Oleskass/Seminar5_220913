// ========================================================================
// №38 Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76; [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
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

//сама программа
PrintResult(RandomArr(ReadData("Введите длину массива: ")));

//генерация массива, поиск максимального и минимального значений и их разница
string RandomArr(int length)
{
    int maxNum = 0;
    int minNum = 0;
    int diffNum = 0;
    int[] array = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    maxNum = array[0];
    minNum = array[0];
    for (int i = 1; i < length; i++) //цикл поиска минимального и максимального значений
    {
        if (array[i] > maxNum) maxNum = array[i];
        if (array[i] < minNum) minNum = array[i];
    }
    diffNum = maxNum - minNum;

    return (string.Join(", ", array) + "\nМаксимальное число: " + maxNum + "\nМинимальное число: " + minNum + "\nРазница между макс. и мин. : " + diffNum);
}