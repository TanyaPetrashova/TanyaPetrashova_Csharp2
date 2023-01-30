// Задача 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

// 1. Ввод и заполнение массива случайными числами от 1 до 10
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);             
    }
}
// 2. Метод печати первого массива
void PrintArray(int[] collection)                                 
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]} ");
        position++;
    }
    Console.WriteLine();
}

// 3. Метод нахождения произведения пар чисел, находящихся по краям
int[] product(int[] array)      // product - произведение                       
{
    int[] resultOfproduct = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)                
    {
        resultOfproduct[i] = array[i] * array[array.Length - 1 - i];
    }
    return resultOfproduct;
}

// 4. Метод печати нового массива с результатами произведений
void PrintResult(int[] collection)                                
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{collection[position]} ");
        position++;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
int[] resultOfproduct = product(array);
PrintResult(resultOfproduct);