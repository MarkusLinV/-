int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArrayFromUser(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}; ");
}  
}





