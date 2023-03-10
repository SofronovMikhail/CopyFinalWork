Console.Clear();
Console.Write("Введите елементы массива через пробел: ");
string element = Console.ReadLine();

string[] GetArray(string el)
{
    string[] num = el.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return num;
}
string[] getArray = GetArray(element);

int Sort(string[] getArray1)
{
    int count = 0;
    foreach(string el in getArray1)
    {
        if(el.Length <= 3)
        {
            count++;
        }
    }
   return count;
}
int quantity = Sort(getArray);


string[] SortArray(string[] getArray2, int quantity1)
{
    int j = 0;
    string[] sortArray = new string[quantity1];
    for(int i = 0; i < getArray2.Length; i++)
    { 
        if(getArray2[i].Length <= 3)
        {
            sortArray[j] = getArray2[i];
            j++;
        }
    }
    return sortArray;
}
string[] sortArray = SortArray(getArray, quantity);

Console.WriteLine($"[{String.Join(", ", getArray)}]");
Console.WriteLine($"[{String.Join(", ", sortArray)}]");