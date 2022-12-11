// task39 Напишите программу, которя перевернет одномерный массив
// [1 2 3 4 5]-> [5 4 3 2 1]; [6 7 3 6]->[6 3 7 6]

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);// [1, 10]
}

int[] ReleaseArray(int[] array)
{
    
    for (int i = 0; i < array.Length / 2;  i++)// прохождение до середины массива
    {
        int temp = array[0];
        array[i] = array[array.Length - i -1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Конечный массив: [{string.Join(", ", ReleaseArray(array))}]");