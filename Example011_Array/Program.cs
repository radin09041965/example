void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10];
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    index = 0;
    position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            positin = index;
        }

        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.writeLine();

int pos = IndexOf(Array, 3);
Console.Write(pos);