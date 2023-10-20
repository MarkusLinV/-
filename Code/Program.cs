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
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}  
}

string[] array = new string[GetNumber("длинны массива array")];
string[] resault = new string[array.Length];

FillArrayFromUser(array);
PrintArray(array);
int n = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        resault[n] = array[i];
        n = n + 1;
    }
}

Console.WriteLine();
PrintArray(resault);
