using System;
using System.Collections.Generic;
using System.IO;

/* Check out the following for better alternatives to DateTime:

Stopwatch:
https://stackoverflow.com/questions/2072361/what-is-the-best-way-to-measure-how-long-code-takes-to-execute
https://stackoverflow.com/questions/28637/is-datetime-now-the-best-way-to-measure-a-functions-performance?rq=1
https://stackoverflow.com/questions/14019510/calculate-the-execution-time-of-a-method/14019526

Performance Counters:
https://stackoverflow.com/questions/1409762/creating-a-perfmon-counter-to-record-an-average-per-call-c/1409833#1409833

*/

    // NOTE: Create a folder called 'test' on your C:\ drive
    // Will create a file there at the end at
    // C:\test\test.csv

namespace SortComparisonsBigO
{
    class Program
    {
        static int[] optSorted1 = new int[10];
        static int[] optSorted2 = new int[1000];
        static int[] optSorted3 = new int[100000];

        static int[] worstSorted1 = new int[10];
        static int[] worstSorted2 = new int[1000];
        static int[] worstSorted3 = new int[100000];

        static int[] randSorted1 = new int[10];
        static int[] randSorted2 = new int[1000];
        static int[] randSorted3 = new int[100000];

        // bubble sort
        static int[] bsOptSorted1 = new int[10];
        static int[] bsOptSorted2 = new int[1000];
        static int[] bsOptSorted3 = new int[100000];

        static int[] bsWorstSorted1 = new int[10];
        static int[] bsWorstSorted2 = new int[1000];
        static int[] bsWorstSorted3 = new int[100000];

        static int[] bsRandSorted1 = new int[10];
        static int[] bsRandSorted2 = new int[1000];
        static int[] bsRandSorted3 = new int[100000];

        // Selection Sort
        static int[] ssOptSorted1 = new int[10];
        static int[] ssOptSorted2 = new int[1000];
        static int[] ssOptSorted3 = new int[100000];

        static int[] ssWorstSorted1 = new int[10];
        static int[] ssWorstSorted2 = new int[1000];
        static int[] ssWorstSorted3 = new int[100000];

        static int[] ssRandSorted1 = new int[10];
        static int[] ssRandSorted2 = new int[1000];
        static int[] ssRandSorted3 = new int[100000];

        // Insertion Sort
        static int[] isOptSorted1 = new int[10];
        static int[] isOptSorted2 = new int[1000];
        static int[] isOptSorted3 = new int[100000];

        static int[] isWorstSorted1 = new int[10];
        static int[] isWorstSorted2 = new int[1000];
        static int[] isWorstSorted3 = new int[100000];

        static int[] isRandSorted1 = new int[10];
        static int[] isRandSorted2 = new int[1000];
        static int[] isRandSorted3 = new int[100000];

        // Quick Sort
        static int[] qsOptSorted1 = new int[10];
        static int[] qsOptSorted2 = new int[1000];
        static int[] qsOptSorted3 = new int[100000];

        static int[] qsWorstSorted1 = new int[10];
        static int[] qsWorstSorted2 = new int[1000];
        static int[] qsWorstSorted3 = new int[100000];

        static int[] qsRandSorted1 = new int[10];
        static int[] qsRandSorted2 = new int[1000];
        static int[] qsRandSorted3 = new int[100000];

        static void Main(string[] args)
        {
            DateTime startTime;
            TimeSpan endTIme;

            // Load Optimally Sorted Arrays, 0 to array.Length
            LoadOptArray(optSorted1);
            LoadOptArray(optSorted2);
            LoadOptArray(optSorted3);

            // Load Worst-case Sorted Arrays, array.Length to 0
            LoadWorstArray(worstSorted1);
            LoadWorstArray(worstSorted2);
            LoadWorstArray(worstSorted3);

            // Load Randomly Sorted Arrays
            LoadRandArray(randSorted1);
            LoadRandArray(randSorted2);
            LoadRandArray(randSorted3);

            // Copy above loaded arrays into BubbleSort arrays for sorting
            LoadBSArrays();

            Console.WriteLine("Sorting Start...");

            // BubbleSort Optimatal
            startTime = DateTime.Now;
            BubbleSort.Sort(bsOptSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsOpt1 = endTIme;
            Console.WriteLine("BS Opt 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            BubbleSort.Sort(bsOptSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsOpt2 = endTIme;
            Console.WriteLine("BS Opt 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            BubbleSort.Sort(bsOptSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsOpt3 = endTIme;
            Console.WriteLine("BS Opt 3: {0:n1} ms", endTIme.Milliseconds);

            // BubbleSort Worst
            startTime = DateTime.Now;
            BubbleSort.Sort(bsWorstSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsWorst1 = endTIme;
            Console.WriteLine("BS Worst 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            BubbleSort.Sort(bsWorstSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsWorst2 = endTIme;
            Console.WriteLine("BS Worst 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            BubbleSort.Sort(bsWorstSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsWorst3 = endTIme;
            Console.WriteLine("BS Worst 3: {0:n1} ms", endTIme.Milliseconds);

            // BubbleSort Random
            startTime = DateTime.Now;
            BubbleSort.Sort(bsRandSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsRand1 = endTIme;
            Console.WriteLine("BS Rand 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            BubbleSort.Sort(bsRandSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsRand2 = endTIme;
            Console.WriteLine("BS Rand 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            BubbleSort.Sort(bsRandSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan bsRand3 = endTIme;
            Console.WriteLine("BS Rand 3: {0:n1} ms", endTIme.Milliseconds);

            // Selection Sort
            LoadSSArray(); // load opt, worst, rand arrays into ss arrays

            // SelectionSort Optimatal
            startTime = DateTime.Now;
            SelectionSort.Sort(ssOptSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssOpt1 = endTIme;
            Console.WriteLine("SS Opt 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            SelectionSort.Sort(ssOptSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssOpt2 = endTIme;
            Console.WriteLine("SS Opt 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            SelectionSort.Sort(ssOptSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssOpt3 = endTIme;
            Console.WriteLine("SS Opt 3: {0:n1} ms", endTIme.Milliseconds);

            // SelectionSort Worst
            startTime = DateTime.Now;
            SelectionSort.Sort(ssWorstSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssWorst1 = endTIme;
            Console.WriteLine("SS Worst 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            SelectionSort.Sort(ssWorstSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssWorst2 = endTIme;
            Console.WriteLine("SS Worst 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            SelectionSort.Sort(ssWorstSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssWorst3 = endTIme;
            Console.WriteLine("SS Worst 3: {0:n1} ms", endTIme.Milliseconds);

            // SelectionSort Random
            startTime = DateTime.Now;
            SelectionSort.Sort(ssRandSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssRand1 = endTIme;
            Console.WriteLine("SS Rand 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            SelectionSort.Sort(ssRandSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssRand2 = endTIme;
            Console.WriteLine("SS Rand 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            SelectionSort.Sort(ssRandSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan ssRand3 = endTIme;
            Console.WriteLine("SS Rand 3: {0:n1} ms", endTIme.Milliseconds);

            // Insertion Sort
            LoadISArray(); // load opt, worst, rand arrays into is arrays

            // InsertionSort Optimatal
            startTime = DateTime.Now;
            InsertionSort.Sort(isOptSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isOpt1 = endTIme;
            Console.WriteLine("IS Opt 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            InsertionSort.Sort(isOptSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isOpt2 = endTIme;
            Console.WriteLine("IS Opt 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            InsertionSort.Sort(isOptSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isOpt3 = endTIme;
            Console.WriteLine("IS Opt 3: {0:n1} ms", endTIme.Milliseconds);

            // InsertionSort Worst
            startTime = DateTime.Now;
            InsertionSort.Sort(isWorstSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isWorst1 = endTIme;
            Console.WriteLine("IS Worst 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            InsertionSort.Sort(isWorstSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isWorst2 = endTIme;
            Console.WriteLine("IS Worst 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            InsertionSort.Sort(isWorstSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isWorst3 = endTIme;
            Console.WriteLine("IS Worst 3: {0:n1} ms", endTIme.Milliseconds);

            // InsertionSort Random
            startTime = DateTime.Now;
            InsertionSort.Sort(isRandSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isRand1 = endTIme;
            Console.WriteLine("IS Rand 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            InsertionSort.Sort(isRandSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isRand2 = endTIme;
            Console.WriteLine("IS Rand 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            InsertionSort.Sort(isRandSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan isRand3 = endTIme;
            Console.WriteLine("IS Rand 3: {0:n1} ms", endTIme.Milliseconds);

            // Quick Sort
            LoadQSArray(); // load opt, worst, rand arrays into qs arrays

            // QuickSort Optimatal
            startTime = DateTime.Now;
            QuickSort.Sort(qsOptSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsOpt1 = endTIme;
            Console.WriteLine("QS Opt 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            QuickSort.Sort(qsOptSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsOpt2 = endTIme;
            Console.WriteLine("QS Opt 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            QuickSort.Sort(qsOptSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsOpt3 = endTIme;
            Console.WriteLine("QS Opt 3: {0:n1} ms", endTIme.Milliseconds);

            // QuickSort Worst
            startTime = DateTime.Now;
            QuickSort.Sort(qsWorstSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsWorst1 = endTIme;
            Console.WriteLine("QS Worst 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            QuickSort.Sort(qsWorstSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsWorst2 = endTIme;
            Console.WriteLine("QS Worst 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            QuickSort.Sort(qsWorstSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsWorst3 = endTIme;
            Console.WriteLine("QS Worst 3: {0:n1} ms", endTIme.Milliseconds);

            // QuickSort Random
            startTime = DateTime.Now;
            QuickSort.Sort(qsRandSorted1);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsRand1 = endTIme;
            Console.WriteLine("QS Rand 1: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            QuickSort.Sort(qsRandSorted2);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsRand2 = endTIme;
            Console.WriteLine("QS Rand 2: {0:n1} ms", endTIme.Milliseconds);

            startTime = DateTime.Now;
            QuickSort.Sort(qsRandSorted3);
            endTIme = DateTime.Now.Subtract(startTime);
            TimeSpan qsRand3 = endTIme;
            Console.WriteLine("QS Rand 3: {0:n1} ms", endTIme.Milliseconds);

            Console.WriteLine("...Sorting Finsihed...");

            Console.WriteLine("...Writing Results to C:\\test\\test.csv...");

            using (TextWriter sw = new StreamWriter("C:\\test\\test.csv"))
            {
                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", "Sort Type", "Opt 1", "Opt 2", "Opt 3", "Worst 1", "Worst 2", "Worst 3", "Rand 1", "Rand 2", "Rand 3");
                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", "BubbleSort", bsOpt1.Milliseconds, bsOpt2.Milliseconds, bsOpt3.Milliseconds, bsWorst1.Milliseconds, bsWorst2.Milliseconds, bsWorst3.Milliseconds, bsRand1.Milliseconds, bsRand2.Milliseconds, bsRand3.Milliseconds);
                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", "SelectionSort", ssOpt1.Milliseconds, ssOpt2.Milliseconds, ssOpt3.Milliseconds, ssWorst1.Milliseconds, ssWorst2.Milliseconds, ssWorst3.Milliseconds, ssRand1.Milliseconds, ssRand2.Milliseconds, ssRand3.Milliseconds);
                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", "InsertionSort", isOpt1.Milliseconds, isOpt2.Milliseconds, isOpt3.Milliseconds, isWorst1.Milliseconds, isWorst2.Milliseconds, isWorst3.Milliseconds, isRand1.Milliseconds, isRand2.Milliseconds, isRand3.Milliseconds);
                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", "QuickSort", qsOpt1.Milliseconds, qsOpt2.Milliseconds, qsOpt3.Milliseconds, qsWorst1.Milliseconds, qsWorst2.Milliseconds, qsWorst3.Milliseconds, qsRand1.Milliseconds, qsRand2.Milliseconds, qsRand3.Milliseconds);

                Console.WriteLine("...Results written to C:\\test\\test.csv");
            }

            
            //Console.WriteLine("{0:n4}", endTIme.Seconds);
            //Console.WriteLine("{0:n4}", endTIme.Milliseconds);

            Console.ReadLine();
        }

        static void LoadOptArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        static void LoadWorstArray(int[] arr)
        {
            int n = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[n] = i;
                n--;
            }
        }

        static void LoadRandArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Random r = new Random();
            for (int i = arr.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = arr[j];
                arr[j] = arr[i - 1];
                arr[i - 1] = k;
            }
        }

        static void LoadBSArrays()
        {
            optSorted1.CopyTo(bsOptSorted1, 0);
            optSorted2.CopyTo(bsOptSorted2, 0);
            optSorted3.CopyTo(bsOptSorted3, 0);

            worstSorted1.CopyTo(bsWorstSorted1, 0);
            worstSorted2.CopyTo(bsWorstSorted2, 0);
            worstSorted3.CopyTo(bsWorstSorted3, 0);

            randSorted1.CopyTo(bsRandSorted1, 0);
            randSorted2.CopyTo(bsRandSorted2, 0);
            randSorted3.CopyTo(bsRandSorted3, 0);
        }

        static void LoadSSArray()
        {
            optSorted1.CopyTo(ssOptSorted1, 0);
            optSorted2.CopyTo(ssOptSorted2, 0);
            optSorted3.CopyTo(ssOptSorted3, 0);

            worstSorted1.CopyTo(ssWorstSorted1, 0);
            worstSorted2.CopyTo(ssWorstSorted2, 0);
            worstSorted3.CopyTo(ssWorstSorted3, 0);

            randSorted1.CopyTo(ssRandSorted1, 0);
            randSorted2.CopyTo(ssRandSorted2, 0);
            randSorted3.CopyTo(ssRandSorted3, 0);
        }

        static void LoadISArray()
        {
            optSorted1.CopyTo(isOptSorted1, 0);
            optSorted2.CopyTo(isOptSorted2, 0);
            optSorted3.CopyTo(isOptSorted3, 0);

            worstSorted1.CopyTo(isWorstSorted1, 0);
            worstSorted2.CopyTo(isWorstSorted2, 0);
            worstSorted3.CopyTo(isWorstSorted3, 0);

            randSorted1.CopyTo(isRandSorted1, 0);
            randSorted2.CopyTo(isRandSorted2, 0);
            randSorted3.CopyTo(isRandSorted3, 0);
        }

        static void LoadQSArray()
        {
            optSorted1.CopyTo(qsOptSorted1, 0);
            optSorted2.CopyTo(qsOptSorted2, 0);
            optSorted3.CopyTo(qsOptSorted3, 0);

            worstSorted1.CopyTo(qsWorstSorted1, 0);
            worstSorted2.CopyTo(qsWorstSorted2, 0);
            worstSorted3.CopyTo(qsWorstSorted3, 0);

            randSorted1.CopyTo(qsRandSorted1, 0);
            randSorted2.CopyTo(qsRandSorted2, 0);
            randSorted3.CopyTo(qsRandSorted3, 0);
        }

        public static class BubbleSort
        {
            public static void Sort<T>(T[] array) where T : IComparable
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            Swap(array, j, j + 1);
                        }
                    }
                }
            }
            public static void Swap<T>(T[] array, int first, int second)
            {
                T temp = array[first];
                array[first] = array[second];
                array[second] = temp;
            }
        }

        public static class SelectionSort
        {
            public static void Sort<T> (T[] array) where T : IComparable
            {
                for(int i = 0; i < array.Length - 1; i++)
                {
                    int minIndex = i;
                    T minValue = array[i];
                    for(int j = i + 1; j < array.Length; j++)
                    {
                        if(array[j].CompareTo(minValue) < 0)
                        {
                            minIndex = j;
                            minValue = array[j];
                        }
                    }
                    Swap(array, i, minIndex);
                }
            }
            public static void Swap<T>(T[] array, int first, int second)
            {
                T temp = array[first];
                array[first] = array[second];
                array[second] = temp;
            }
        }

        public static class InsertionSort
        {
            public static void Sort<T>(T[] array) where T : IComparable
            {
                for(int i = 1; i < array.Length; i++)
                {
                    int j = i;
                    while(j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                    {
                        Swap(array, j, j - 1);
                        j--;
                    }
                }
            }
            public static void Swap<T>(T[] array, int first, int second)
            {
                T temp = array[first];
                array[first] = array[second];
                array[second] = temp;
            }
        }

        public static class QuickSort
        {
            public static void Sort<T>(T[] array) where T : IComparable
            {
                Sort(array, 0, array.Length - 1);
            }
            private static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
            {
                if(lower < upper)
                {
                    int p = Partition(array, lower, upper);
                    Sort(array, lower, p);
                    Sort(array, p + 1, upper);
                }
                return array;
            }
            private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
            {
                int i = lower;
                int j = upper;
                //T pivot = array[lower]; // using this one cause a StackOverflow Exception when you get to qsOpt2 for some reason, maybe can't handle large arrays
                /* or:*/ T pivot = array[(lower + upper) / 2];
                do
                {
                    while (array[i].CompareTo(pivot) < 0) { i++; }
                    while (array[j].CompareTo(pivot) > 0) { j--; }
                    if (i >= j) { break; }
                    Swap(array, i, j);
                }
                while (i <= j);
                return j;
            }
            public static void Swap<T>(T[] array, int first, int second)
            {
                T temp = array[first];
                array[first] = array[second];
                array[second] = temp;
            }
        }
    }
}
