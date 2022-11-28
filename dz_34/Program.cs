/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
 */
//создаём переменную которая принимает массив чисел и запускаем функцию FillArray
int[] mass = FillArray(5);
//функция  EvenNum получает массив mass и возвращает int сколько четных чисел.
Console.WriteLine(EvenNum(mass));
Print(mass);
//функция принимает
//отдаёт число   функция   целочисленный массив     принимает целочисленный массив и отдаёт число
int EvenNum(int[] array)
{
    int newEven = 0;
    //          345    [345, 897, 568, 234]
    foreach(var item in array)
    {
        if (item %2 == 0)
        {
            newEven++;
        }
    }
    return newEven;
}
//функция принимает значение и возвращает массив целых чисел.

//отдаёт целочисленный массив       функция    принимает число
int[] FillArray(int length) //принимает число и отдаёт массив
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
