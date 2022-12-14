// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;

Clear();
WriteLine("Задача 10");
WriteLine("Введите трехзначное число");
int num1=Convert.ToInt32(ReadLine());
if (num1>999 || num1<-999) WriteLine("По условию число должно быть трехзначным");
else {
    int n2=Math.Abs((num1/10)%10);
    WriteLine($"Вторая цифра {n2}");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

WriteLine();
WriteLine("Задача 13");
WriteLine("Введите число");
int num2=Convert.ToInt32(ReadLine());
int n3=Math.Abs((num2/100)%10);
if (n3<=0) {
    WriteLine("Третьей цифры нет");
}
else {
    WriteLine($"Третье число {n3}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

WriteLine();
WriteLine("Задача 15");
WriteLine("Введите номер дня недели п/п");
int num3=Convert.ToInt32(ReadLine());
if (num3<=0) WriteLine("Число дожно быть больше 0");
if (num3>7) WriteLine("Дней недели всего 7");
if (num3>=1 && num3<=5) WriteLine("Нет, будний");
if (num3==6 || num3==7) WriteLine("Да, выходной");