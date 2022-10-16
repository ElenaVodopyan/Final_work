// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

string[] FillArray(int size)
{
    string[] strings = new string[size];
    for (int i = 0; i < strings.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива {i+1}");
        strings[i] = Console.ReadLine();
    }
    return strings;
}

string[] CheckArray(string[] array)
{
    string[] result = new string[0];     
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) {
            string[] temp = new string[result.Length +1];
            Array.Copy(result, temp, result.Length);     
            temp[result.Length] = array[i];
            result = temp;
        }
    }
    return result;
}

void ShowArray(string[] array)
{
    
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"{array[i]} ");    
    }
    Console.Write("]");
    Console.WriteLine();
}

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] result = FillArray(size);
result = CheckArray(result);
ShowArray(result);

