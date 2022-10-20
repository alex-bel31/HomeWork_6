// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string GetAndPrintValue(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    return input;
}
string array = GetAndPrintValue("Введите массив: ");
string[] array1 = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array2 = new int[array1.Length];

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = int.Parse(array1[i]);
}

int count = 0;
for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] > 0)
    {
        count++;
        
    }
}

Console.Write($" -> {count}");
