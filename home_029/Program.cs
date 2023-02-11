// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.


int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray()
{
    int[] arr = new int[8];
    var rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

var myarray = GetArray();
PrintArray(myarray);