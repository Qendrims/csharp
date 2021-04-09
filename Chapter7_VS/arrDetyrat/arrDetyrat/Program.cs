using System;

namespace arrDetyrat
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Detyra1
             int[] arr = new int[20];

             for (int i = 0; i < arr.Length; i++)
             {
                 arr[i] = 5 * i;
                 Console.WriteLine(arr[i]); 
             } 

            detyra 2.
            Console.Write("Shkruaj gjatsine e Array1: ");
            int gjatesia = Int32.Parse(Console.ReadLine());

            int[] arr1 = new int[gjatesia];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Shkruaj vlerat: ");
                arr1[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Shkruaj gjatesine e Array2: ");
            int gjatesia2 = Int32.Parse(Console.ReadLine());



            if (gjatesia != gjatesia2) Console.WriteLine("Gjatesia e arrays eshte e ndryshme.");
            else
            {
                int[] arr2 = new int[gjatesia2];
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write("Shruaj vlerat: ");
                    arr2[i] = Int32.Parse(Console.ReadLine());
                }
            if (arr1 == arr2) Console.WriteLine("Arrays jane te barabarta.");
            else Console.WriteLine("Arrays kan vlera te ndryshme."); 
            }  


            detyra4
            int count = 1, tempCount = 1, number = 0;

            Console.WriteLine("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;
                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }
            for (int i = 0; i < count; i++) Console.WriteLine("{0}", number); 

            
            Console.Write("Shkruaj gjatsine e array: ");
            int gjatsia = Int32.Parse(Console.ReadLine());
            int[] array = new int[gjatsia];

            for (int i = 0; i < gjatsia; i++)
            {
                Console.Write("array[{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < gjatsia; i++)
            {
                for (int j = i + 1; j < gjatsia; j++)
                {
                    if (array[i + 1] == array[j] && array[i] < array[j])
                    {
                        Console.WriteLine(array[i]);
                        break;
                    }
                }
            } 

            detya 6.
            int counter = 0, tempIndex, tempCounter;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = tempCounter = 1;
                tempResult[0] = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[j] > tempResult[tempIndex - 2] && arr[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = arr[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0},", result[i]);  


            Detyra 7.
            int sum = 0;
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter k (k < n): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);  


            detyra 8.
            int i, j, iMin, temp;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            } 

            for (j = 0; j < length - 1; j++)
            {
                iMin = j;

                for (i = j + 1; i < length; i++)
                {
                    if (arr[i] < arr[iMin])
                    {
                        iMin = i;
                    }
                }
                if (iMin != j)
                {
                    temp = arr[j];
                    arr[j] = arr[iMin];
                    arr[iMin] = temp;
                }
                
            }
            for (i = 0; i < length; i++) Console.Write("{0} ", arr[i]); 


            detyra 9.
            int sum = 0, tempSum;
            Console.Write("Enter array lenght: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length - 1; i++)
            {
                tempSum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum) sum = tempSum;
                }
            }
            Console.WriteLine("Result ={0} ", sum);  


            detyra 10.
            int counter = 0, tempCounter = 1, foundNumber = 0;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter the Value of array[{0}]: ", i);
                arr[i] = Int32.Parse(Console.ReadLine()); 
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    foundNumber = arr[i];
                }
            }

            Console.WriteLine("{0} was found {1} times.", foundNumber, counter);   


            dettyra 11.
            int sum = 0, start = 0, end = 0;
            bool sumFound = false;

            Console.Write("Enter S: ");
            int s = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Array Length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter element [{0}]: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length - 1; i++)
            {
                sum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }
                if (sumFound) break;
            }
            if (sumFound) for (int i = start; i <= end; i++) Console.Write("{0},", arr[i]);
            else Console.WriteLine("No sum found.");  

            detyra.12
            Console.Write("Shkruaj numrin e rreshtave te matrices: ");
            int rows = Int32.Parse(Console.ReadLine());

            Console.Write("Shkruaj numrin e kolonave te matrices: ");
            int cols = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.Write("Enter the cells of matrix;");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Matrica[{0},{1}]= ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("  " + matrix[row, col]);
                }
                Console.WriteLine();
            }  */



            int row = 0, col = 0, sum = -1000;

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter M: ");
            int m = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Arr [{0}] [{1}] = ", i, j);
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int tempRow = 0; tempRow < arr.Length - 2; tempRow++)
            {
                for (int tempCol = 0; tempCol < arr.GetLength(0) - 2; tempCol++)
                {
                    int tempSum = arr[row, col] + arr[row, col + 1] + arr[row, col + 2] + arr[row + 1, col] +
                        arr[row + 1, col + 1] + arr[row + 1, col + 2] + arr[row + 2, col] + arr[row + 2, col + 1] + arr[row + 2, col + 2];

                    if (tempSum > sum)
                    {
                        row = tempRow;
                        col = tempCol;
                        sum = tempSum;
                    }
                }
            }
            Console.WriteLine("Result");
            Console.WriteLine("{0} {1} {2}", arr[row, col], arr[row, col + 1], arr[row, col + 2]);
            Console.WriteLine("{0} {1} {2}", arr[row + 1, col], arr[row + 1, col + 1], arr[row + 1, col + 2]);
            Console.WriteLine("{0} {1} {2}", arr[row + 2, col], arr[row + 2, col + 1], arr[row + 2, col + 2]);
            Console.WriteLine("The maximum sum is {0}.", sum);

        }
    }
}
 
