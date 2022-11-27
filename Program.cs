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