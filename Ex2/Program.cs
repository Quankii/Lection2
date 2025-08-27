
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int lenth = collection.Length;
    byte count = 0;
    while(count < lenth)
    {
        Console.WriteLine(collection[count]);
        count++;
    }
}

void MaxArray(int[] collection, int find)
{
    int lenth = collection.Length;
    int index = 0;
    int posistion = 0;
    while (index < lenth)
    {
        if (collection[index] == find)
        {
            Console.WriteLine(find + " is have. Position: " + index);
            posistion = index;
        }
        index++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
MaxArray(array, 3);