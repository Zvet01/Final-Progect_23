// Итоговый проект
// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] myArray = FillArray();
string[] resultArray = MyNewArray(myArray);
string ResArray = PrintArray(resultArray);
Console.WriteLine(ResArray);

string[] FillArray() // заполняем массив
{
    Console.WriteLine("Введите значения или символы через пробел или запятую : ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; }; // заменяем пробел на кавычки
    char[] separators = new char[] { '/','?',',', ' ' }; // учитываем, что можно по разному ставить пробелы и запятые
    string[] myArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return myArray;
}
string PrintArray(string[] myArray)
{
    string stringArray = "[";
    for (int i = 0; i < myArray.Length; i++)
    {
        if (i == myArray.Length - 1)
        {
            stringArray += $"\"{myArray[i]}\"";
            break;
        }
        stringArray += ($"\"{myArray[i]}\", "); //элементы массива
    }
    stringArray += "]";
    return stringArray;
}
int CountStringSymbols(string[] myArray) 
{
    int counter = 0;
    foreach (string item in myArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}
string[] MyNewArray(string[] myArray)
{
    int resultArrayLength = CountStringSymbols(myArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in myArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

