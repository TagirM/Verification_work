//Задача из контрольной работы.

string A1 = "hello";
string A2 = "hi";
string A3 = "goodmoning";
string A4 = "buy";

string[] array = new string[] { A1, A2, A3, A4 };
string A5 = string.Join("; ", array);
System.Console.WriteLine($"Задан массив из строк: {A5} ");
System.Console.Write("Новый массив строк с длиной символов не более 3: ");
int i = 0; // i - index(int i = 0)
int n = 0;
int arraySize = array.Length; // Длина массива - количество элементов

while (i < arraySize)
{
    if (array[i].Length <= 3)
    {
        System.Console.Write($"{array[i]}; ");
        n++;
    }
    i++;
}
if (n == 0) System.Console.Write("таких строк нет");

