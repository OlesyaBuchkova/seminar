//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
int[] FillArray()
{
    int[] array = new int[8]; 
    for (int index = 0; index < array.Length; index ++)
    {
        array[index] = new Random().Next(0, 2); 
    }
    return array;
}
void Print(int[] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        Console.WriteLine(array[index] + " ");
    }
}
Print(FillArray());

//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write(array[i] + " ");
//}
//Console.WriteLine();
//foreach (int element in array) {
//    Console.Write(element + " ");
//}
//Console.WriteLine();
//string arrayOutput = String.Join(", ", array);
//Console.WriteLine("[" + arrayOutput + "]");

//варианты вывода массива