//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16



int GetNumber(string arg)
{
    Console.WriteLine(arg);
    string number = Console.ReadLine();
    int result = int.Parse(number);
    return result;
}

bool ChechNumbers(int count)
{
    if(count>0)
    {
        Console.WriteLine("This number is less than 0. Try again: ");
    }
    return true;
}

int num= GetNumber("input number: ");
int count=GetNumber("input second number: ");
    if(ChechNumbers(count));
    {
        Console.WriteLine($"Result => {Math.Pow(num, count)}");
    }
