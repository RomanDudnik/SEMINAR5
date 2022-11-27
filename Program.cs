//Задайте массив из 12 эл-овб заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных эл-ов массива.

/*
int [] CreateRandomArray (int size, int minValue, int maxValue)   //метод создания массива с рандом эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray (int [] array)     // метод демонстрации массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindSummPos(int[] array)
{
    int sumPos = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumPos += array[i];
    return sumPos;
}

int FindSummNeg(int[] array)
{
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sumNeg += array[i];
    return sumNeg;
}

int sizeArray = 12;
int minValueArray = -9;
int maxValueArray = 9;

int[] createArray = CreateRandomArray(sizeArray, minValueArray, maxValueArray);
ShowArray(createArray);
Console.WriteLine($"Summ of positive elements is {FindSummPos(createArray)}");
int resultNeg = FindSummNeg(createArray);
Console.WriteLine($"Summ of negative elements is {resultNeg}");
*/

//Найдите произведение пар чисел в одномерном массиве.
//Парой чисел считаем первый и последний эл-т, второй и предпоследний и т.д.
//Результат запишем в новом массиве.
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21

/*
int [] CreateRandomArray (int size, int minValue, int maxValue)   //метод создания массива с рандом эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray (int [] array)     // метод демонстрации массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] FindMultiPair (int[] arrayCreated)
{
    int size2;
    if (arrayCreated.Length % 2 == 0)
        size2 = arrayCreated.Length / 2;     // длинна массива с произведениями
    else size2 = (arrayCreated.Length + 1) / 2;
        
    int [] arrayMulti = new int[size2];

    for (int i = 0; i < arrayCreated.Length / 2; i++)
    {
        arrayMulti[i] = arrayCreated[i] * arrayCreated[arrayCreated.Length -1 - i];   //тк i увеличивается каждый цикл и ее нужно тоже отнять (для движения одновременно с двух сторон)
    }
    if(arrayCreated.Length % 2 != 0 )
        //arrayMulti[size2 -1] = arrayCreated[(arrayCreated.Length)/2];    //можно так
        arrayMulti[size2 -1] = arrayCreated[size2-1];
    return arrayMulti;
}

Console.WriteLine("Input size if array: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minValue array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxValue array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(arraySize, minValue, maxValue);
ShowArray(array1);
int[] array2 = FindMultiPair(array1);
ShowArray(array2);
*/

//Задайте одномерный массив из 123 случайных чисел.
//Найдите ко-во элементов массива, значения которых лежат в отрезке [10, 99].

int [] CreateRandomArray (int size, int minValue, int maxValue)   //метод создания массива с рандом эл-ами
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray (int [] array)     // метод демонстрации массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountNext(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 9 && array[i] < 100)
            count++;
    return count;

}

Console.WriteLine("Input min possible val if array: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible val if array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int sizeArray = 123;

int[] arrayCreated = CreateRandomArray(sizeArray, minVal, maxVal);
ShowArray(arrayCreated);

int res = CountNext(arrayCreated);
ShowArray(arrayCreated);
Console.WriteLine($"Count of elements between 10 and 99 is {res} ");



