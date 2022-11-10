string[] array = new string[] { "Russia", "Don", "Hello", "Crimea", "Kia", "01", "193" };
string[] newArray = new string[array.Length];

void PrimaryStringArray(string[] array, string[] newArray)
{ 
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($" {array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
PrimaryStringArray(array, newArray);
Console.WriteLine("Основной массив");
PrintArray(array);
Console.WriteLine("Исправленный массив");
PrintArray(newArray);

