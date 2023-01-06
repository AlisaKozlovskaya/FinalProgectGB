// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

Console.WriteLine("Введите число элементов массива:");
int N = int.Parse(Console.ReadLine());

if (N <= 0) //проверка на отрицательность размера массива
{
    Console.WriteLine("Введите число больше нуля");
}

void PrintArray(string[] arr) // метод печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[N]; 
for (int i = 0; i < N; i++) // заполнение исходного массива
    {
        Console.WriteLine($"Введите {i+1}-й элемент массива из {N}:");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
PrintArray(array);

int count = 0;
string[] arrayNoMoreThree = new string[array.Length];
for (int i = 0; i < N; i++)
    {
    if (array[i].Length <= 3)
        {
        arrayNoMoreThree[count] = array[i];
        count++;
        }
    }

PrintArray(arrayNoMoreThree);