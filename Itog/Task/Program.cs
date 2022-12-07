// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которого меньше, либо равна 3 символа.
// просим пользователя заполнить массив
Console.WriteLine("Введите любые 5 слов или символов через Enter:");
string[] array = new string[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}
// выводим массив 
Console.Write("Массив до сортировки: ");
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}  ");
}