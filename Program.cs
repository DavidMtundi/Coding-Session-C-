// See https://aka.ms/new-console-template f
Console.WriteLine("Hello world");
int[] first = { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] printedarray = insert(first, 9);
int[] insertedarray = insertlocation(first, 3, 1);

for (int i = 0; i < printedarray.Length; i++)
{
    Console.WriteLine(printedarray[i]);
}

Console.WriteLine("\n\n");

for (int i = 0; i < insertedarray.Length; i++)
{
    Console.WriteLine(insertedarray[i]);
}
//inserts at a the last location
int[] insert(int[] arr, int value)
{
    int[] finalarray = new int[arr.Length + 1];

    for (int i = 0; i < arr.Length; i++)
    {
        finalarray[i] = arr[i];
    }
    finalarray[arr.Length] = value;

    return finalarray;

}
///inserts a specific location
int[] insertlocation(int[] arr, int value, int position)
{
    int[] finalarray = new int[arr.Length + 1];
    for (int i = 0; i < arr.Length + 1; i++)
    {
        if (i < position)
        {
            finalarray[i] = arr[i];
        }
        else if (i == position)
        {
            finalarray[position] = value;
        }
        else
        {

            finalarray[i] = arr[i - 1];
        }
    }
    return finalarray;
}