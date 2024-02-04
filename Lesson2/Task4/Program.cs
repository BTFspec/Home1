int n = 5;
int[] array = { 2, 3, 6, 5, 8 };
int i = 0;
int max = array[0];
while(i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

// ЦИКЛЫ
// ЦИКЛ for используем где знаем количество элементов масиива. //когда требуется перебрать элементы массива
// ЦИКЛ while в задчах где верхняя граница числа итераций неизвестна
// ЦИКЛ foreach работает так же как и циклFOR только в нем не используются индексы массива

max = array[0];
for(int j = 0; j < n; j++) // j++ это j = j + 1;
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);

///////////////////////////////

max = array[0];
foreach(int e in array)
{
    if (e > max)   // В цикле обращение к массиву с помощью буквы которой обозначили буква е например
    {
        max = e;
    }
}
Console.WriteLine(max);
