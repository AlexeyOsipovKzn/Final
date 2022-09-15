Console.Clear();
Console.Write("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine();
string[] array = GetArray(size);

Console.WriteLine();
PrintArray(array);
PrintNewArray(array);


// Ввод массива 
string[] GetArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива:  ");
        array[i] = Console.ReadLine();
    }
    return array;

}

//Вывод массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == string.Empty) continue;
        Console.Write("\"" + array[i] + "\"" + ", ");
    }
    Console.Write("\"" + array[array.Length - 1] + "\"" + "]" + " --> ");
}

//формируем массив строк по условию задачи
void PrintNewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == string.Empty) continue;
        else if (array[i].Length <= 3) Console.Write("\"" + array[i] + "\"" + ", ");
    }
    Console.Write("\"" + array[array.Length - 1] + "\"" + "]");
}
