/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

// Функция ввода массива с клавиатуры
using System.Collections;

string[] GetArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int arLength = 0;
    int.TryParse(Console.ReadLine(), out arLength);
    string[] array = new string [arLength];
    Console.WriteLine("Введите строки массива");
    for (int i = 0; i < arLength; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

// Произвольное заполнение массива
string[] RandArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int arLength = 0;
    int.TryParse(Console.ReadLine(), out arLength);
    string[] array = new string [arLength];
    string str = "abcdefghijklmnopqrstuvwxyzабвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789!№?*%;:()-_+=";
    Random rand = new Random();
    for (int i = 0; i < arLength; i++)
    {
        array[i] = "";
        int strLength = rand.Next(10);
        for (int j = 0; j < strLength; j++)
        {
            array[i] += str[rand.Next(str.Length)];
        }
    }
    return array;
}

// Функция создания массива из строк меньше трёх символов
string [] NewArray(string[] baseArray)
{
    int newLength = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length < 4)
        {
            newLength++;
        }
    }
    string[] newArray = new string[newLength];
    newLength = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i].Length < 4)
        {
            newArray[newLength] = baseArray[i];
            newLength++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите 'y', если массив задается вручную");
string answer = Console.ReadLine();
string[] newArray;
if (String.Equals(answer, "y"))
{
    newArray = GetArray();
}
else
{
    newArray = RandArray();
}

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
Console.Write("[");
if (newArray.Length > 0)
{
    Console.Write("\"" + newArray[0] + "\"");
}
for (int i = 1; i < newArray.Length; i++)
{
    Console.Write(", \"" + newArray[i] + "\"");
}
Console.Write("] → [");
string[] new3Array = NewArray(newArray);
if (new3Array.Length > 0)
{
    Console.Write("\"" + new3Array[0] + "\"");
}
for (int i = 1; i < new3Array.Length; i++)
{
    Console.Write(", \"" + new3Array[i] + "\"");
}
Console.Write("]");

