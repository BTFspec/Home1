
// int[] array = {2, 3, 6, 5, 8};
//             int min = array[0];
//             int max = array[0];      
//             for (int i = 0; i < array.Length; i++)
//             {
//                 if (array[i] < min)
//                 {
//                      min=array[i];
//                 }
//                 if (array[i] > max)
//                 {
//                    max=array[i];
//                 } 
//             }
//             return max - min;


// using System.ComponentModel.DataAnnotations;

// double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
//             double min = array[0];
//             double max = array[0];      
//             for (int i = 0; i < array.Length; i++)
//             {
//                 if (array[i] < min)
//                 {
//                      min=array[i];
//                 }
//                 if (array[i] > max)
//                 {
//                    max=array[i];
//                 } 
//             }
//             double result = (max-min);
//             Console.WriteLine(result);


using System.Security.Cryptography.X509Certificates;

namespace helloworld;

    class Hello
    {
        static void Main()
        {
          static int FindMax(int[] myArray) // static это от функции
          {
            // string x = "Влад";
            // return x;

         int max = myArray[0];
           for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                   max=myArray[i];
                } 
            }
            return max;
          }

           static int FindMin(int[] myArray) // static это от функции
          {
            // string x = "Влад";
            // return x;

         int min = myArray[0];
           for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > min)
                {
                   min=myArray[i];
                } 
            }
            return min;
          }
          static void printResult (int[] myArray)
          {
            int result = FindMax(myArray) - FindMin(myArray);
            Console.Write(result);
          }
          int[] numbers = {7,1,5,6,3};
         // Console.WriteLine(FindMax(numbers));
         printResult(numbers);
        }
    }
