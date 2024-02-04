
// МАССИВЫ

// int[] arr = new int [5]; // arr имя массива. желательно давать тот который будет в тему. смотря с какими данными работаешь.

//  int[] //тип даннных элементов массива.
//  int[] arr = new int [5]; // new int [5]; выделение памяти от элемента массива    // = связывание памяти и имени массива.


int[] arr = new int[5]; // если бы был вещественный тип то вместо int написали бы dooble в двух местах
arr[0] = 5;
arr[1] = 2;
arr[2] = 4;
arr[3] = 8;
arr[4] = 9;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

// Console.WriteLine(arr[5]);

int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
int[] arr3 = { 1, 2, 3, 4, 5 }; // для создания небольшого массива когда известны элементы
                                             // можно сделать массив без выделения памяти.