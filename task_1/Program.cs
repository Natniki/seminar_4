//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int multi(int A,int B){
    int result = Convert.ToInt32(Math.Pow(A, B));
    return result;
}

Console.WriteLine("input number A: ");
int num = GetIntNumber();
Console.WriteLine("input number B: ");
int count = GetIntNumber();
Console.WriteLine(multi(num, count));


