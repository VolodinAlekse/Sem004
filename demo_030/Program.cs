// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]} ");
//     }
// }
// int[] FillArray( int size)
// {
//     int[] arrN = new int[size];
//     for (int i = 0; i < 8; i++)
//     {
//         arrN[i] = new Random().Next(0, 2);
//     }
//     return arrN;
// }
// int[] myarray = FillArray(8);

// PrintArray(myarray);




// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] GetArray()
// {
//     int[] arr = new int[8];
//     var rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// for (int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write(arr[i] + " ");
// }
// System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// var myarray = GetArray();
// PrintArray(myarray);
