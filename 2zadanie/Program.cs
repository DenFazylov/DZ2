﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string msg) // объявление функции
{
    Console.WriteLine(msg); // пишет на экран параметр msg
    string num = Console.ReadLine(); //присвоение введенному числу имени num
    int a = int.Parse(num); //преобразование введеного числа из строки в число
    return a; // возврат из функции значения
} //описание функции заканчивается
int a = ReadInt("Введите число"); //вызываем функцию
if (a > 99) // Условие чтобы число было больше 99
{
    while (a/10>100) //запуск цикл, чтобы получить трехначное число путем деления на 10 несколько раз
    {
        a=a/10; //деление на 10
    }
    
    Console.WriteLine(a%10); // вывод остатка на 10 полученного трехначного числа
}
else Console.WriteLine("третьей цифры нет"); // если введено не трехзначное число