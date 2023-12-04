string[] array1 = new string[5] { "123", "hello", "23", "res", "world" };
string[] array2 = new string[array1.Length];

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}");
    }
    System.Console.WriteLine();
}

NewArray(array1, array2);
PrintArray(array2);