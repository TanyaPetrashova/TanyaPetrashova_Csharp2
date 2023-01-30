// Задача 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

// 1. Метод создания и заполнения массива случайными числами от 1 до 10
void FillArray(int[] collection)                                 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);             
        index++;
    }
}

// 2. Метод печати созданного массива на экран
void PrintArray(int[] collection)                                 
{
    int count = collection.Length;
    int currentPosition = 0;
    while (currentPosition < count)
    {
        Console.Write($"{collection[currentPosition]} ");
        currentPosition++;
    }
    Console.WriteLine();
}

// 3. Метод нахождения произведения пар чисел, находящихся по краям
// numProduct - произведение чисел 
int[] numProduct(int[] array)                                      
{
    int[] numProductResult = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)                
    {
        numProductResult[i] = array[i] * array[array.Length - 1 - i];
    }
    return numProductResult;
}

// 4. Метод печати на экран нового массива с результатами произведений
void PrintResult(int[] collection)                                
{
    int count = collection.Length;
    int currentPosition = 0;
    while (currentPosition < count)
    {
        Console.Write($"{collection[currentPosition]} ");
        currentPosition++;
    }
}

int[] array = new int[10];   
FillArray(array);
PrintArray(array);
int[] numProductResult = numProduct(array);
PrintResult(numProductResult);
