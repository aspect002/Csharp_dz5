﻿/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */
int[] mass = FillArray(5);
Print(mass);
Position(mass);
 //создаёт функцию которая ничего не принимает и ничего не возвращает
void Position(int[] array)
{
    int newEven = 0; //счётчик
    for(var i = 0; i < array.Length; i++) //перебирает каждый элемент в массиве
    { //если мы рассматриваем со стороны человека, то первое число в массиве у нас будет считаться нечётным
    //если мы рассматриваем со стороны программы, то нулевой элемент массива у нас будет считаться чётным.
        if (i %2 == 0) //определяет есть ли остаток
        {
            newEven += array[i];//сложение нечётных элементов массива.
        }
    }
    Console.WriteLine(newEven);//выводит  количество счётчика
}
//функция отдаёт массив и принимает число
int[] FillArray(int length)
{
    int[] array = new int[length]; //создаём переменную эрей в которой будет присвоено значение length(5)
    for(int i = 0; i < length; i++)//условие счётчик равен 0, пока счётчик меньше чем число 5,то проваливаемся в тело
    {
        array[i] = new Random().Next(-99, 99);// каждому элементу массива присваивается рандомное число
    }
    return array;//возвращает все 5 элементов массива с присовенным им рандомным числом
}
//функция ничего не отдаёт и ничего не принимает
void Print(int[] array)
{
    foreach(var item in array)//перебирает каждый элемент в массиве и выводит его
    {
        Console.Write($"{item}, ");
    }
    System.Console.WriteLine("");
}