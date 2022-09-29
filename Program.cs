// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

/// <summary>
/// функция создания массива с текстовыми элементами по заданной длине
/// </summary>
/// <param name="len">длина массива</param>
/// <returns>массив</returns>
string[] CreateArray(int len)
{
    string[] array = new string[len];

    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите элемент {i + 1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

/// <summary>
/// функция печати массива в консоль
/// </summary>
/// <param name="arr">необходимый для печати массив</param>
void PrintArray(string[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

/// <summary>
/// функция добавление элемента в конец массива
/// </summary>
/// <param name="array">исходный массив</param>
/// <param name="elem">добавляемый элемент</param>
/// <returns>искомый массив</returns>
string[] AddElemArray(string[] array, string elem)
{
    string[] resArray = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        resArray[i] = array[i];
    }
    resArray[array.Length] = elem;
    return resArray;
}

/// <summary>
/// функция получения массива из элементов массива, длина которых меньше 4
/// </summary>
/// <param name="array">исходный массив</param>
/// <returns>искомый массив</returns>
string[] GetArrayElemLess3Char(string[] array)
{
    string[] resArray = new string[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        resArray = array[i].Length <= 3 ? AddElemArray(resArray, array[i]) : resArray;
    }
    return resArray;
}

Console.WriteLine("Введите элемент длину массива: ");
int lengthArray = int.Parse(Console.ReadLine());
string[] arrayString = CreateArray(lengthArray);
Console.WriteLine();
PrintArray(arrayString);
PrintArray(GetArrayElemLess3Char(arrayString));
PrintArray(GetArrayElemLess3Char(new string[] { "Hello", "2", "world", ":-)" }));
PrintArray(GetArrayElemLess3Char(new string[] { "1234", "1567", "-2", "computer science" }));
PrintArray(GetArrayElemLess3Char(new string[] { "Russia", "Denmark", "Kazan" }));
