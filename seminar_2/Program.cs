// ЗАДАЧА 1

// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int number = 453; // ввели переменную number int цифровая переменнная.
// int FirstDigit = number / 100;    // 453 /100 = 4 ввевели переменную где будет храниться первая цифра т.е. сотни"4ка"НАЙТИ1ЦИФРУ
// int ThirdDigit = number % 10; // 453 / 10% = 3 остаток получаем цифру 3. % 10 такой знак дает остаток в ответ 
// int result = FirstDigit * 10 + ThirdDigit;  // 4 * 10 + 3 = 43
// // $"Текст {result} текст {a+100} текст {a - 500}"
// Console.WriteLine($"В числе {number} => {result}");

// ЗАДАЧА 2

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625

// int number = 947;
// int secondDigit = number / 10 % 10; // 947 / 10 = 94 / 10 = 4 Нашли вторую цифру которую будем потом возводить НАЙТИ ВТОРУЮ ЦИФРУ
// int thirdDigit = number % 10; // 947 % 10 = 7 это мы нашли третью цифру НАЙТИ ТРЕТЬЮ ЦИФРУ
// int result = (int)Math.Pow(secondDigit, thirdDigit);  // Math.Pow возводит в степень. 4^7 = 28. 4 в степени 7 будет 16384
// // перед Math.Pow ставим (int) чтобы перевести из вещественного dooble в числовой int. // Math.Pow вещественный метод.
// Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");
//      // 4 ^ 7 = 16384

// ЗАДАЧА 3

//  Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// int number = 12707;
// if (number >= 100) // Число минимум трехзначное. if-это если. если число больше либо равно 100
//        // от 100 до плюс бесконечности
// {
//  int thirdDigitFromEnd = (number / 100) % 10; // поделили на 100 = 127 а потом на остаток % 10  и получили 7 третья цифра с конца
//     Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
// }
// else // если число меньше 100 В ЧИСЛЕ НЕТ ТРЕТЬЕЙ ЦИФРЫ
// {
// Console.WriteLine($"В {number} нет третьей цифры");
// }

// ЗАДАЧА 4 

//   Обсуждение решений
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// int a = 5;
// int b = 2;
// if (a % b ==0) // если а делится на b без остатка ПРОВЕРКА НА РАВЕНСТВО в конце
// {
//  Console.WriteLine($"число {a} кратно числу {b} так как делится без остатка");
// }
// else // если при делении числа а есть остаток то
// {
//     Console.WriteLine($"В числе {a} при делении на число {b} есть остаток {a % b}");
// }

//HOMEWORK

// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Добавил массив // https://metanit.com/sharp/tutorial/2.4.php
// Перебор массивов
// Для перебора массивов мы можем использовать различные типы циклов. Например, цикл foreach:

// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int i in numbers)
// {
//     Console.WriteLine(i);
// }

// ПРИМЕР:
// a=50 => нет
// a=7 => нет
// a=322 => да

// int [] numbersQ1 = {50, 7, 322};
// int D = 7;
// int S = 23;
// foreach (int i in numbersQ1) 
// {
// {
// Console.Write($"Число {i + " "}");
// }
// if (i % D ==0 && i % S ==0)
// {
//     Console.WriteLine($"одновременно кратно числу {D} и числу {S}.");
// }
// else
// {
//     Console.WriteLine($"не кратно одному из чисел или обоим числам {D} и {S}.");
// }
// }


// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// ПРИМЕР
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

// int X = 2;
// int Y = 3;
// if (X > 0 && Y > 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат первой четверти.");
// }
// if (X < 0 && Y > 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат второй четверти.");
// }
// if (X < 0 && Y < 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат третьей четверти.");
// }
// if (X > 0 && Y < 0)
// {
//     Console.WriteLine($"координаты точек {X} и {Y} принадлежат четвертой четверти.");
// }



// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Добавил две функции к программе: 1.if (digit <= 99 && digit >= 10) 2. else if (oneDigit == secondDigit)
// вот здесь смотрел https://metanit.com/sharp/tutorial/2.5.php
// При необходимости можно добавить несколько выражений else if:
// string name = "Alex";

// if (name == "Tom")
//     Console.WriteLine("Вас зовут Tomas");
// else if (name == "Bob")
//     Console.WriteLine("Вас зовут Robert");
// else if (name == "Mike")
//     Console.WriteLine("Вас зовут Michael");
// else
//     Console.WriteLine("Неизвестное имя");


// int digit = 66;
// if (digit <= 99 && digit >= 10)
// {
// int oneDigit = (digit / 10);
// int secondDigit = (digit % 10);
//  if (oneDigit < secondDigit)
// {
//     Console.WriteLine($"Число {digit} это {oneDigit} и {secondDigit}. {secondDigit}>{oneDigit}.");
// }
// else if (oneDigit > secondDigit)
// {
//     Console.WriteLine($"Число {digit} это {oneDigit} и {secondDigit}. {oneDigit}>{secondDigit}.");
// }
// else if (oneDigit == secondDigit)
// {
//     Console.WriteLine($"Число {digit} это {oneDigit} и {secondDigit}. Большего нет, числа равны {oneDigit}={secondDigit}.");
// }
// }
// else 
// {
//     Console.WriteLine($"Число {digit} не подходит. Напишите число от 10 до 99.");
// }

// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// ПРИМЕР:
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

// int N = 240;
// if (N < 10)

// {
//      Console.WriteLine(N);
// }
// else
// {
//     while(N > 0);
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }



// Задача 4: Вывод цифр числа через запятую


// int N = 456;
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0)
// {
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }

// int myInt = 21325425;
//  string myString = myInt.ToString(); // моя строка это мое число в строке в символах
// char[] charArray = myString.ToCharArray(); // Массив = моей строке 
// foreach (char i in charArray) // цикл foreach проход массива 
// {
// int charparse = int.Parse(i.ToString()); // делаем из символов числа
//     Console.Write(charparse + ",");

// }



// double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
//             double min = array[0];
//             double max = array[0];
// int result = 0;
//            array  = new double [7];
           
//             for (int i = 0; i < array.Length; i++)
//             {
            
//                 if (array[i] < min)
//                 {
//                      min=array[0];
//                 }
//                 if (array[i] > max)
//                    max=array[0];
//                 }  
//                 {           
//                 return result;
//                 }
//     Console.WriteLine(max);
//     Console.WriteLine(min);

        

