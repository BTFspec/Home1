int i1 = 5;
int i2 = 6;
int sum = i1 + i2; // тип данных операции сложения будет операться на тип вводимых данных если тип данных одинаковый              
                       // в ответе будет тоже самое.
Console.WriteLine(sum); //вывод суммы двух значений

long l1 = 6; 
long sum2 = l1 + i1; // если складываем два разных типа данных пишем что более всместителен. int+long=long!
Console.WriteLine(sum2);

double d1 = 5.5;
double sum3 = d1 +i1; // если складываем два разных типа данных пишем тот что более разностаронен.
                       // тип данных double хранит и целые и дробные числа. double+int=double
Console.WriteLine(sum3);

int product1 = l1 * i2;
long product2 = i1 * i1;
double product3 = i1 * d1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotient = i1 / i2;
Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1;
Console.WriteLine(quotient2); // при разных типах данных ставим тот где будет виден результат.тот тип данных который позволяет 
                              // вместить в данном случае это double. int / doble = double
