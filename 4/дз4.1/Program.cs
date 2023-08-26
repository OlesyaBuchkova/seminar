// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Mat(int number1, int number2)
{
    int result = number1;
    for (int i = 1; i < number2; i++){
        result *= number1;
    }
        return result;
}
int number1 = Print("Введите число1");
int number2 = Print("Введите число2");
Console.WriteLine(Mat(number1, number2));