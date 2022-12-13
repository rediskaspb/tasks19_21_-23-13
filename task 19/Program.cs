// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
string N = Console.ReadLine();
int count = N.Length;
if(count < 5 || count > 5) 
{
    Console.WriteLine("Число не пятизначное");
}
else if (N[0]==N[4] && N[1]==N[3]) 
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
