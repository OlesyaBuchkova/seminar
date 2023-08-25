//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
int[] ConstrutArray(int arrayLenght){
    int[] array = new int[arrayLenght];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0,2);
    }
    return array;
}
void Print(int [] array){
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
Print(ConstrutArray(8));


