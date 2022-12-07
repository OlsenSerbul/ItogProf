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
// перемешиваем элементы массива, чтобы программа выдала случайные,а не по порядку
Random rand = new Random();
 
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int j = rand.Next(i + 1);
 
        string temp = array[j];
        array[j] = array[i];
        array[i] = temp;
    }
Console.WriteLine(); 
// проверяем 
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}  ");
}
Console.WriteLine();
Console.Write("Массив после сортировки: ");
// метод сортировка элементов со случайным количеством элементов до 3
void SortArray(string[] array)
{ 
    int N = array.Length;
    N = new Random().Next(1, 4);
    for(int i = 0; i < N; i++ )
    {
         Console.Write($"{array[i]}  ");
    }
}
SortArray(array);