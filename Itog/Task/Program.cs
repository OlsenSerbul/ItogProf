// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которого меньше, либо равна 3 символа.
// просим пользователя заполнить массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
Console.WriteLine("Введите любые 5 слов или символов через Enter:");
string[] array = new string[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}
 
Console.Write("Массив до сортировки: ");
PrintArray(array);

Random rand = new Random();

for (int i = array.Length - 1; i >= 0; i--)
{
    int j = rand.Next(i + 1);

    string temp = array[j];
    array[j] = array[i];
    array[i] = temp;
}
Console.WriteLine();

Console.Write("Массив после сортировки: ");

void SortArray(string[] array)
{
    int N = array.Length;
    N = new Random().Next(1, 4);
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}
SortArray(array);