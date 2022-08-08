// string[] newArray = { "hello", "2", "world", ":-)" };
string[] newArray = { "1234", "1567", "-2", "computer science" };
// string[] newArray = { "Russia", "Denmark", "Kazan"};

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else if (i == array.Length - 1) Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

void PrintSortedArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        string word = array[i];
        if (word.Length <= 3) Console.Write ($"{word} ");
        }
    Console.Write("]");
}


PrintArray(newArray);
Console.Write(" -> ");
PrintSortedArray(newArray);