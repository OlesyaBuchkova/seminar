//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] FillArray()
{
    int[] array = new int[8]; 
    for (int index = 0; index < array.Length; index ++)
    {
        array[index] = new Random().Next(0, 9); 
    }
    return array;
}
void Print(int[] array)
{
    for (int index = 0; index < array.Length; index ++)
    {
        Console.Write(array[index] + ", ");
    }
}
Print(FillArray());
