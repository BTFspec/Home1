
double CalculateFormula(int a, int b, int c, int d)   // функция;
{
    double numenator = a * b;                         // тело функции;
    int denumenator = c + d;
    double result = numenator / denumenator;  // "double / int = double" т.к. double более вместительный а нам нужна дробная часть;            
    return result;
}

 CalculateFormula(1, 2, 3, 4); // запуск функции; Если хотим запустить через консоль пустые скобки- CalculateFormula();

 double result = CalculateFormula(1, 2, 3, 4);  // чтобы сохранить результат из фунции создадим переменную с типом данных double;
 Console.Write(result); // вывод ответа в терминал;