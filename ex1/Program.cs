// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число из 5 символов: ");
string number = Console.ReadLine();

if (number.Length != 5)  Console.WriteLine($"Число не пятизначное, повторите ввод");
else 
{
    if (number[0]==number[4] && number[1]==number[3]) Console.WriteLine($"Число: {number} - палиндром.");
    else Console.WriteLine($"Число: {number} - не палиндром.");
}



