/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArrey(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0, 10000);
        index++;
    }
    Console.WriteLine($"[{string.Join(", ", collection)}]");
}

int[]arrey= new int[8];
FillArrey(arrey);
