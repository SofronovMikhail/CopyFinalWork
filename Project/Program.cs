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