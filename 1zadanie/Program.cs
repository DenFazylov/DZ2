﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int ReadInt(string msg) // объявление функции
{
    Console.WriteLine(msg); // пишет на экран параметр msg
    string num = Console.ReadLine(); //присвоение введенному числу имени num
    int a = int.Parse(num); //преобразование введеного числа из строки в число
    return a; // возврат из функции значения
} //описание функции заканчивается
int a = ReadInt("Введите трехзначное число"); //вызываем функцию
if (a > 99 & a < 1000) // два условия. Первое-чтобы число было больше 99. Второе - если чтобы число было меньше 1000
{
    int b = (a % 100 - a % 10) / 10; // операция нахождения второй цифры
    Console.WriteLine(b); // вывод полученной цифры
}
else Console.WriteLine("Введенное число не трехзнаное"); // если введено не трехзначное число
