// // тип_метода ИмяМетода (пар1, пар2, ... парN)
// // a, b - 2 числа, sign - знак арифм. операции
// int Calculate(int a, int b, string sign)
// {
//     if (sign == "+")
//     {
//         return a + b; // Cумма чисел
//     }
//     else if (sign == "-")
//     {
//         return a - b; // Разность чисел
//     }
//     else if (sign == "*")
//     {
//         return a * b; // Произ-е чисел
//     }
//     else
//     {
//         Console.WriteLine("Введен неизвестный знак арифм. операции");
//         return 0;
//     }
// }

// // Вызов метода 
// Console.WriteLine(Calculate(2, 2, "+")); // 5
// Console.WriteLine(Calculate(2, 2, "-")); // 0
// Console.WriteLine(Calculate(20, 3, "*")); // 60
// Console.WriteLine(Calculate(20, 3, ".")); // 60


// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
                                                                                                   //  ЧАСТЬ 1
// int[] CreateArray(int size)    // делаем фунцию на создание массива.    
// {
//     int[] array = new int[size]; // Массив на size элементов //если делаем через  new int там каждый елемент это 0.
//     for (int i = 0; i < array.Length; i++)  // проходим циклом for и заполняем каждый его элемент
//     {
//         array[i] = new Random().Next(1, 101); //обращаемся к каждому элементу и кладем туда рандомное число;
//                                               //Next это генерация рандомных чисел; задаем границу от 1 д0 101;
//         // [1, 101) или [1,100]
//     }
//     return array;   // возвращаем массив уже заполненый рандомно числами; 
// }     
//                                                                                                      //  ЧАСТЬ 2
// int GetCount(int[] arr)  //     делаем функцию  поиска нужного числа;
// {
//     int count = 0;                         // 
//     for (int i = 0; i < arr.Length; i++)
//     {
//         // "&&" - "И": апельсины И яблоки
//         if (arr[i] % 7 == 0 && arr[i] % 10 == 1) //число делится на 7 без остатка и делится 10 и дает остаток 1 однёрку; 
//         {
//             count++; // count = count + 1 
//             // Число нашли
//         }
//     }
//     return count;
// }


// // Вызов метода
// Console.Write("Введите число: "); // на сколько чисел создать массив; создаст на то которое введем;
// int N = Convert.ToInt32(Console.ReadLine());   //конвертация числа из строчного символьного в переменную инт. через Convert.
// int[] res = CreateArray(N); // Создали массив на N элементов
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]"); // создали массив через функцию res и выводим его в консоль;
// Console.WriteLine($"Результат: {GetCount(res)}"); // вывод если делится на 7 и остаток 1


// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем
// [2, 3, 1] => 231

int[] CreateArray(int size)
{
    int[] array = new int[size]; // Массив на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10); // [0, 9]
    }
    return array;
}

int ConvertArrayToInteger(int[] array)   // Конвертация массива в формат одного целого числа;
{
    int result = 0;
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--) // j=это степень она на 1ку меньше чем ваш массив
    {
        result = result + array[i] * (int)Math.Pow(10, j);
        // 10 - число, j - степень
    }
    return result;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N); // Создали массив на N элементов
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Результат: {ConvertArrayToInteger(res)}");