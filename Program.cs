namespace Assignment8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implement Quick Sort

            int[] array = { 1, 29, 16, 43, 12, 5, 80, 30, 44, 17, 21, 44, 15, 63, 33, 13 };
            Console.WriteLine("Unsorted array is:");
            printArray(array);
            quickSort(array, 0, array.Length-1);
            Console.WriteLine("Sorted array is:");
            printArray(array);


        }

        public static void quickSort(int[] array, int l, int r)
            //recursively uses quicksort/partician to break down array sub array subsequently smaller
        {
            if (l < r)
            {
                int p = partician(array, l, r);
                quickSort(array, l, p - 1);
                quickSort(array, p + 1, r);
            }
        }

        public static int partician(int[] array, int l, int r)
            //using last value  "r" in subarray "array" as a pivot point to sort elements. 
        {
            while (l < r)
            {
                while (array[l] <= array[r] && l < r)
                {
                    l++;
                }
                for (int j = l+1; j < r; j++)
                {
                    if (array[j] <= array[r])
                    {
                        swap(array, l, j);
                        l++;
                    }
                }
                break;
            }
            swap(array, l, r);
            return l;
        }

            public static void swap(int[] array, int i1, int i2)
            {
                //takes index of two points in array and swaps the values
                int temp = array[i1];
                array[i1] = array[i2];
                array[i2] = temp;
            }
             public static void printArray(int[] array)
            {
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }


