using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrDetyrat2
{
    class Program
    {
        /* static void Main(string[] args)
         {
              Detyra 14.
               int tempSeq = 1, seq = 1;
               string element = "e";

               Console.Write("Enter N: ");
               int n = Int32.Parse(Console.ReadLine());
               Console.Write("Enter M: ");
               int m = Int32.Parse(Console.ReadLine());

               string[,] arr = new string[n, m];

               for (int i = 0; i < n; i++)
                   for (int j = 0; j < m; j++)
                   {
                       Console.Write("Arr [{0}][{1}] = ", i, j);
                       arr[i, j] = Console.ReadLine();
                   }


               for (int rows = 0; rows < arr.GetLength(0); rows++)
               {
                   for (int cols = 0; cols < arr.GetLength(1) - 1; cols++)
                   {
                       if (arr[rows, cols] == arr[rows, cols + 1]) tempSeq++;
                       else tempSeq = 1;

                       if (seq < tempSeq)
                       {
                           seq = tempSeq;
                           element = arr[rows, cols];
                       }
                   }
                   tempSeq = 1;
               }

               for (int cols = 0; cols < arr.GetLength(1); cols++)
               {
                   for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)
                   {
                       if (arr[rows, cols] == arr[rows + 1, cols]) tempSeq++;
                       else tempSeq = 1;

                       if (seq < tempSeq)
                       {
                           seq = tempSeq;
                           element = arr[rows, cols];
                       }
                   }
                   tempSeq = 1;
               }

               for (int i = 0; i < arr.GetLength(0) - 1; i++)
                   for (int j = 0; j < arr.GetLength(1) - 1; j++)
                   {
                       for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols < arr.GetLength(1) - 1; rows++, cols++)
                       {
                           if (arr[rows, cols] == arr[rows + 1, cols + 1]) tempSeq++;
                           else tempSeq = 1;

                           if (seq < tempSeq)
                           {
                               seq = tempSeq;
                               element = arr[rows, cols];
                           }
                       }
                       tempSeq = 1;
                   }

               for (int i = 0; i < arr.GetLength(0) - 1; i++)
                   for (int j = 1; j < arr.GetLength(1); j++)
                   {
                       for (int rows = i, cols = j; rows < arr.GetLength(0) - 1 && cols > 0; rows++, cols--)
                       {
                           if (arr[rows, cols] == arr[rows + 1, cols - 1]) tempSeq++;
                           else tempSeq = 1;

                           if (seq < tempSeq)
                           {
                               seq = tempSeq;
                               element = arr[rows, cols];
                           }
                       }
                       tempSeq = 1;
                   }

               for (int i = 0; i < seq; i++) Console.Write("{0}, ", element);  


             deyta 15.
             char[] alfabeti = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

             Console.Write("Shkruaj nje fjale: ");
             char[] fjala = (Console.ReadLine()).ToCharArray();

             for (int i = 0; i < fjala.Length; i++)
             {
                 for (int j = 0; j < alfabeti.Length; j++)
                 {
                     if (fjala[i] == alfabeti[j]) Console.Write("{0}", j);  
                 }
             }  



        Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Element of array{0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Enter searched number: ");
            int number = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, number);

            if (index >= 0) Console.Write("Number is on {0} index.", index);
            else Console.Write("Number wasn't found.");
        } */

        /* static public void DoMerge(int[] numbers, int left, int mid, int right)
         {
             int[] temp = new int[25];
             int i, left_end, num_elements, tmp_pos;

             left_end = (mid - 1);
             tmp_pos = left;
             num_elements = (right - left + 1);

             while((left <= left_end) && (mid <= right))
             {
                 if (numbers[left] <= numbers[mid]) temp[tmp_pos++] = numbers[left++];
                 else temp[tmp_pos++] = numbers[mid++];
             }

             while (left <= left_end) temp[tmp_pos++] = numbers[left++];
             while (mid <= right) temp[tmp_pos++] = numbers[mid++];

             for(i = 0; i < num_elements; i++)
             {
                 numbers[right] = temp[right];
                 right--;
             }
         }

         static public void MergeSort_Recursive(int[] numbers, int left, int right)
         {
             int mid;

             if (right > left)
             {
                 mid = (right + left) / 2;
                 MergeSort_Recursive(numbers, left, mid);
                 MergeSort_Recursive(numbers, (mid + 1), right); 
             }
         }

         static void Main(string[] args)
         {
             Console.Write("Enter array length: ");
             int length = Int32.Parse(Console.ReadLine());

             int[] arr = new int[length];

             for(int i =0; i < length; i++)
             {
                 Console.Write("Enter element{0}: ", i);
                 arr[i] = Int32.Parse(Console.ReadLine());
             }

             MergeSort_Recursive(arr, 0, arr.Length - 1);

             for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
         } 

         public static void QuickSort(int[] elements, int left, int right)
         {
             int i = left, j = right;
             IComparable pivot = elements[(left + right) / 2];

             while (i <= j)
             {
                 while (elements[i].CompareTo(pivot) < 0) i++;

                 while (elements[j].CompareTo(pivot) > 0) j--;

                 if (i <= j)
                 {
                     int tmp = elements[i];
                     elements[i] = elements[j];
                     elements[j] = tmp;
                     i++;
                     j--;
                 }
             }

             if (left < j) QuickSort(elements, left, j);
             if (i < right) QuickSort(elements, i, right);
         }

         static void Main(string[] args)
         {
             Console.Write("Enter array length: ");
             int length = Int32.Parse(Console.ReadLine());

             int[] arr = new int[length];

             for (int i = 0; i < length; i++)
             {
                 Console.Write("Enter element {0}: ");
                 arr[i] = Int32.Parse(Console.ReadLine());
             }

             QuickSort(arr, 0, arr.Length - 1);

             for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
         } 

        static void PrintList(List<int> nums, bool printZero = true)
        {
            foreach (int n in nums)
            {
                if (!printZero && n == 0) continue;
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            for (int i = 2; i <= 10000; i++) nums.Add(i);

            int p = 2;
            int indexAt = 0;
            bool limitReached = false;

            while (!limitReached)
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    int v = nums[i];
                    if (v % p == 0 && v != p) nums[i] = 0;
                }
                do
                {
                    p = nums[++indexAt];
                    if (indexAt >= nums.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (p == 0);
            }

            PrintList(nums, false);
        } 

        static int wantedSum;
        static bool solution = false;

        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
        {
            if (index == elementsInSubset)
            {
                CheckSubsets(subset, elementsInSubset);
                return;
            }

            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            int sum = 0;

            for (int i = 0; i < elementsInSubset; i++) sum += subset[i];

            if (sum == wantedSum)
            {
                for (int i = 0; i < elementsInSubset; i++) Console.Write("{0} ", subset[i]);

                Console.WriteLine();
                solution = true;
            }
        }

        static void Main()
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter S: ");
            wantedSum = int.Parse(Console.ReadLine());

            int[] subset = new int[length];

            for (int i = 1; i <= length; i++) GenerateSubset(arr, subset, 0, 0, i);

            if (!solution) Console.WriteLine("No subset with sum {0} found.", wantedSum);
        } 



        public static int[] findSolution(int[] a, bool[] filter, int index, int s, int size)
        {
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = findSolution(a, filter, index + 1, s, size);

                if (x.Length > 0) return x;
                else
                {
                    filter[index] = false;
                    return findSolution(a, filter, index + 1, s, size);
                }
            }
            else
            {
                int sum = 0, count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += a[i];
                        count++;
                    }
                }
                int[] solution = new int[0];

                if (sum == s && count == size)
                {
                    solution = new int[count];
                    count = 0;

                    for (int i = 0; i < a.Length; i++) if (filter[i]) solution[count++] = a[i];
                }
                return solution;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K = ");
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Sum of elements, s = ");
            int s = Int32.Parse(Console.ReadLine());
            int[] solution = findSolution(arr, new bool[arr.Length], 0, s, size);

            Console.WriteLine("Your solution:");
            for (int i = 0; i < solution.Length; i++) Console.Write(solution[i] + "; ");
            Console.ReadLine();
        } 


        static void Main(string[] args)
        {

            int subsets = 0;
            int longestLength = 0;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for(int i = 0; i < length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int m = (1 << length);
            int[,] subset = new int[m, length];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < length; j++) subset[i, j] = i / (m / 2 / (1 << j)) % 2;
            }
            for (int i = 0; i < m; i++)
            {
                int max = -1000, count = 0;

                for (int j = 0; j < length; j++)
                {
                    if (subset[i, j] > 0)
                    {
                        if (arr[j] >= max)
                        {
                            count++;
                            max = arr[j];
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count)
                {
                    longestLength = count;
                    subsets = i;
                }
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < length; i++) if (subset[subsets, i] > 0) Console.Write(arr[i] + "; ");
        } */


        public static int n;

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[k];

            recSolution(arr, 0);
        }

        static void recSolution(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    recSolution(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
