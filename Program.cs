// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


int num = new Random().Next(1,5);
System.Console.WriteLine(num);

int firstElement = 1;

PrintNumbers(firstElement,num);

void PrintNumbers(int startElement,int endElement)
{
    System.Console.WriteLine(startElement);
    if (endElement <= startElement)
    {
        return;
    }

    PrintNumbers(startElement+1,endElement);
}

// Напишите программу вычисления функции Аккермана
// с помощью рекурсиию Даны два неотрицательных
// числа m и n.

System.Console.WriteLine();
System.Console.WriteLine($"{Ackermann(3,2)}");
System.Console.WriteLine($"{Ackermann(2,3)}");

int Ackermann(int m,int n)
{
    if(m==0)
    {
        return n+1;
    }
    else if(n==0)
    {
        return Ackermann (m-1,1);
    }
    else
    {
        return Ackermann (m-1,Ackermann (m,n-1));
    }    
    
}

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


System.Console.WriteLine("Input the length of random array:");
int userLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateArray(userLength);
PrintArray(userArray);
PrintReverseArray(userArray, userLength);

// Создаем рандомный массив чисел
int[] CreateArray(int length)

{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i<length; i++)
    {
        array[i] = random.Next(1,100);
    }
    return array;

}


void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();

}


void PrintReverseArray(int[] array, int length)
{
    if (length == 1) Console.Write($"{array[0]}");

    else
    {
        Console.Write($"{array[length-1]}");
        PrintReverseArray(array,length-1);
    }
}