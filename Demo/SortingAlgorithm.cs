using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Declare Delegate
    //public delegate bool ConditionFuncDelegate (int A, int B);
    //public delegate bool ConditionFuncDelegatev02 (string A, string B);

    public delegate bool ConditionFuncDelegate<T>(T A, T B);

    public class SortingAlgorithm
    {
        // generic version
        public static void BubbleSort<T>(T[] arr, ConditionFuncDelegate<T> Reference)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (Reference.Invoke(arr[j], arr[j + 1]))
                        {
                            //SWAP
                            SWAP(ref arr[j], ref arr[j + 1]);

                        }
                    }
                }
            }
        }

        // public static void BubbleSort(string[] arr, ConditionFuncDelegatev02 Reference)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (Reference.Invoke(arr[j], arr[j + 1]))
        //                {
        //                    //SWAP
        //                    SWAP(ref arr[j], ref arr[j + 1]);
        //
        //                }
        //            }
        //        }
        //    }
        //}
        public static void BubbleSortAscending(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (SortingFunctions.CompareGtr(arr[j], arr[j + 1]))
                        {
                            //SWAP
                            SWAP(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
        private static void SWAP(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        private static void SWAP(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }

        //generic
        private static void SWAP<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSortDescending(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (SortingFunctions.CompareLess(arr[j], arr[j + 1]))
                        {
                            //SWAP
                            SWAP(ref arr[j], ref arr[j + 1]);

                        }
                    }
                }
            }
        }

    }

    public class SortingFunctions
    {
        public static bool CompareGtr(string l, string r) { return l.Length > r.Length; }
        public static bool CompareLess(string l, string r) { return l.Length < r.Length; }

        public static bool CompareGtr(int l, int r) { return l > r; }
        public static bool CompareLess(int l, int r) { return l < r; }

    }
}
