/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

Дополнительная задача (40): Задайте одномерный массив, заполненный случайными числами. 
Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.

[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами
*/
Console.Clear();
int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}
int GetSizeArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
// int size = GetSizeArray();
// Console.WriteLine(size);
// int[] array = new int [size];
// array = GetRandomArray(size, 100, 1000);
// Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.Write("Введите номер задачи: ");
int task = int.Parse(Console.ReadLine());
if (task == 34)
{
    Task34();
}
else if (task == 36)
{
    Task36();
}
else if (task == 38)
{
    Task38();
}
else if (task == 40)
{
    Task40();
}
else if (task == 42)
{
    Task42();
}

void Task34()
{
    /* 
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
    */
    Console.Clear();
    int size = GetSizeArray();
    int[] array = new int[size];
    array = GetRandomArray(size, 100, 1000);
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    int GetEvenNumbers(int[] array)
    {
        int even = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) even++;
        }
        return even;
    }
    int result = GetEvenNumbers(array);
    Console.WriteLine(result);
}

void Task36()
{
    /*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
    */
    Console.Clear();
    int size = GetSizeArray();
    int[] array = new int[size];
    array = GetRandomArray(size, -10, 10);
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    int GetSumOddIndex(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i = i + 2)
        {
            sum = sum + array[i];
        }
        return sum;
    }
    int result = GetSumOddIndex(array);
    Console.WriteLine(result);
}

void Task38()
{
    /*
    Задача 38: Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
    */
    Console.Clear();
    int size = GetSizeArray();
    int[] array = new int[size];
    array = GetRandomArray(size, 0, 100);
    Console.WriteLine("[" + String.Join(", ", array) + "]");
    int GetDifferenceNumber(int[] array)
    {
        int min = array[0];
        int max = array[0];
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }
        result = max - min;
        return result;
    }
    int result = GetDifferenceNumber(array);
    Console.WriteLine(result);
}

void Task40()
{
    /*
    Дополнительная задача (40): Задайте одномерный массив, заполненный случайными числами. 
    Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
    Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
    [1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
    [2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
    [1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами
    */
    int size = GetSizeArray();
    int[] array = new int[size];
    array = GetRandomArray(size, 0, 10);
    //Console.WriteLine("[" + String.Join(", ", array) + "]");
    int GetEvenValue(int[] array) {
        int even = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] % 2 == 0) even++; 
        }
        return even;
    }
    int[] evenArray = new int[GetEvenValue(array)];
    //Console.WriteLine("[" + String.Join(", ", evenArray) + "]");
    int GetOddValue(int[] array) {
        int odd = 0;
        for (int j = 0; j < array.Length; j++) {
            if (array[j] % 2 > 0) odd++;
        }
        return odd;
    }
    int[] oddArray = new int[GetOddValue(array)];
    //Console.WriteLine("[" + String.Join(", ", oddArray) + "]");
    int[] GetEvenNumber(int[] evenArray, int[] array) {
        int indexEven = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] % 2 == 0) {
                evenArray[indexEven] = array[i];
                indexEven++;
            } 
        }
        return evenArray;
    }
    int[] GetOddNumber(int[] oddArray, int[] array) {
        int indexOdd = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] % 2 > 0) {
                oddArray[indexOdd] = array[i];
                indexOdd++;
            } 
        }
        return oddArray;
    }
    evenArray = GetEvenNumber(evenArray, array);
    oddArray = GetOddNumber(oddArray, array);
    //Console.WriteLine("[" + String.Join(", ", evenArray) + "]");
    //Console.WriteLine("[" + String.Join(", ", oddArray) + "]");
    int AveregeArithmetic(int[] array) {
        int averege = 0;
        for (int i = 0; i < array.Length; i++) {
            averege = averege + array[i];
        }
        averege = averege / array.Length;
        return averege;
    }
    int arrayEven = AveregeArithmetic(evenArray);
    int arrayOdd = AveregeArithmetic(oddArray);
    //Console.WriteLine($"средн. арифм. значений элементов массива с чётными числами {arrayEven}");
    //Console.WriteLine($"средн. арифм. массива значений элементов с нечётными числами {arrayOdd}");
    void Comparison() {
        if (arrayEven > arrayOdd) {
            Console.WriteLine("средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами");
        } else if (arrayOdd > arrayEven) {
            Console.WriteLine("средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами");
        } else if (arrayEven == arrayOdd) {
            Console.WriteLine("средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами");
        }
    }
    Comparison();
}

void Task42()
{
    /*

    */

}