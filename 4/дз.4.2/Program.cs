//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SumAll(int number)
{
    int result = 0;
    while (number > 0){
        result += number % 10;
        number = number / 10;
    }  
    return result;
}
int number = Print ("Введите число");
Console.WriteLine (SumAll(number));