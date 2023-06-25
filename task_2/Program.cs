/*
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetIntNumber(string description)
{
    int number;
    Console.WriteLine($"{description}=> ");

    while(true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
         return number;   
        }
        Console.WriteLine($"Thus number {temp} is not correct. Try again: ");
    }
}

int SumOFnumbers(int arg)
{
    int sum = 0;
    while(arg>0)
    {
        sum += arg % 10;
        arg = arg / 10;
    }
    return sum;
}

int number=(GetIntNumber("input number: "));
Console.WriteLine(($"sum all numbers {number} => {SumOFnumbers(number)}"));

