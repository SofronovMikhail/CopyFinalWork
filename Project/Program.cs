Console.Clear();
Console.Write("Введите елементы массива через пробел: ");
string element = Console.ReadLine();
//Пользователь вводит значения массива вручную.
//Метод создания строчного массива.
string[] GetArray(string el)
{
    string[] num = el.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return num;
}
string[] getArray = GetArray(element);

//Метод проверки у скольки элементов строчного массива, 
// значение меньше  трех символов.
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

//метод создания строчного, отсортированного массива значение элементы которого,
// берутся из первого массива у которых не больше трех злементов.
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

// вывод первого массива и отсортированного из него же второго массива.
Console.WriteLine($"[{String.Join(", ", getArray)}]");
Console.WriteLine($"[{String.Join(", ", sortArray)}]");