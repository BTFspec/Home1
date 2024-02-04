int n = 10;
int[] arr = new int [n];
int i = 0;

while (i < n) // можно while (i < arr.Length) так же обращается к нашему массиву
{
    arr[i] = i + 1;
    //Console.Write(arr[i]);
    //Console.Write(" ");
    Console.Write($"{arr[i]} ");
    i = i + 1;
}