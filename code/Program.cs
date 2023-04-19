// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int size = Message ("Введите количество элементов массива: ");
string[] stringArray = FillMatrix(size);
PrintMatrix(stringArray);
string[] newMatrix = MatrixStringsWith3OrLessSymbols(stringArray);
Console.Write(" --> ");
PrintMatrix(newMatrix);

int Message (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[] FillMatrix(int size)
{
    string[] matrix = new string[size];
    for (int i = 0; i < size; i++)
    {
      Console.WriteLine($"Введите {i+1} элемент массива: ");
      matrix[i] = Console.ReadLine();
    }
    return matrix;
}

void PrintMatrix(string[] matrix)
{
    Console.Write("[ ");
    for (int i = 0; i < matrix.Length; i++)
    {
        if (i<matrix.Length-1) Console.Write($"{matrix[i]}, ");
        else Console.Write($"{matrix[i]}");
    }
    Console.Write("]");
}

string[] MatrixStringsWith3OrLessSymbols (string[] matrix)
{
    int newSize=0;
    
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <=3 ) newSize++;
    }
    string[] newMatrix = new string[newSize];
    int j=0;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <=3 ) 
        {
            newMatrix[j]=matrix[i];
            j++;
        }
    }
    return newMatrix;
}