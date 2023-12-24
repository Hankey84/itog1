int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] FillArray(int size)
{
    string[] tempArray = new string[size];

    for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    tempArray[i] = Console.ReadLine()!;
    Console.WriteLine();
}

return tempArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}



int size = ReadInt("Введите размер массива: ");
string[] myArray = FillArray(size);
PrintArray(myArray);
;
