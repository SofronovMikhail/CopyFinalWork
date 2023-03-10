Console.Clear();
Console.Write("Введите елементы массива через пробел: ");
string element = Console.ReadLine();

string[] GetArray(string el)
{
    string[] num = el.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return num;
}
string[] getArray = GetArray(element);
