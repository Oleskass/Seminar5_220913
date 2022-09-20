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

//генерация массива и проверка на чётные числа
string RandomArr(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();

    int evenNum = 0;
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            evenNum++;
        }
    }

    return (string.Join(", ", array) + "\nЧётных чисел в массиве: " + evenNum);
}

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//сама программа
PrintResult(RandomArr(ReadData("Введите длину массива: ")));
