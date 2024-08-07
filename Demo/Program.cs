using Demo;
using System;
namespace ADV
{
    // Class
    // Struct
    // Enum
    // interface

    // Step 0 : Decalare Delegate

    public delegate int StringFuncDelegate(String Str);
    //New Delegate(Class) ,  Reference From Delegate refer to Func or More [pointer To Func]
    //these Must be Has The Same Signature Of Delegate : int(String)
    //Regarless Funcatin Nameing [Func Names or Parameter Names] , Access Modifiers

    public delegate bool ConditionFuncDelegate(int A);
    public delegate bool ConditionFuncDelegate<T>(T A);

    internal class Program
    {
        static Action Fun01()
        {
            //Action action = delegate () { Console.WriteLine("Hello World"); };
            //Action action1 = () => { Console.WriteLine("Hello World"); };
            //Action action2 =  () => Console.WriteLine("Hello World");
            //
            //return action;
            return () => Console.WriteLine("Hello World");
        }
        public static List<int> FindNumber(List<int> list, ConditionFuncDelegate Reference)
        {
            List<int> result = new List<int>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Reference.Invoke(list[i]))
                        result.Add(list[i]);
                }
            }
            return result;
        }
        // public static List<int> FindOddNumber(List<int> list)
        // {
        //     List<int> result = new List<int>();
        //
        //     if(list is not null)
        //     {
        //         for(int i = 0; i < list.Count; i++)
        //         {
        //             if (ConditionFunctions.Checkodd(list[i])) // odd
        //                 result.Add(list[i]);
        //         }
        //     }
        //     return result;
        // }

        // public static List<int> FindEvenNumber(List<int> list )
        // {
        //     List<int> result = new List<int>();
        //
        //     if (list is not null)
        //     {
        //         for (int i = 0; i < list.Count; i++)
        //         {
        //             if (ConditionFunctions.CheckEven(list[i])) // Even
        //                 result.Add(list[i]);
        //         }
        //     }
        //     return result;
        // }

        // public static List<int> DevisibleBy4(List<int> list)
        // {
        //     List<int> result = new List<int>();
        //
        //     if (list is not null)
        //     {
        //         for (int i = 0; i < list.Count; i++)
        //         {
        //             if (ConditionFunctions.CheckDevisibleBy4(list[i]))
        //                 result.Add(list[i]);
        //         }
        //     }
        //     return result;
        // }

        public static List<T> FindElements<T>(List<T> list, ConditionFuncDelegate<T> Reference)
        {
            List<T> result = new List<T>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Reference.Invoke(list[i]))
                        result.Add(list[i]);
                }
            }
            return result;
        }
        //Predicate
        public static List<T> FindElements<T>(List<T> list, Predicate<T> Reference)
        {
            List<T> result = new List<T>();

            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Reference.Invoke(list[i]))
                        result.Add(list[i]);
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            // Delegate : C# language Feature
            // pure oop
            // Usages : 
            // 1. Functional Programming
            //// 1.1 Store Funcation in a variable
            //// 1.2 pass l Funcation as a parmeter o another Function
            //// 1.3 return l Funcation throgh Funcation
            // 2. Event_Driven Programming
            // Java Pure oop -->
            // 1. Use Functinal Programming --> usage Statege Design Pattern
            // 2. Use Event_Driven Programming --> usage apservier Design Pattern

            #region Delegate EX01

            // Step 01 :  Declare Reference From Type StringFuncDelegate [Delegate]
            //StringFuncDelegate Reference = StringFunctions.GetCountOfUpperCaseChar;

            //Reference = StringFunctions.GetCountOfLowerCaseChar;

            //Reference += StringFunctions.GetCountOfLowerCaseChar;

            // Step 02 :  Use [Function] Throught Reference
            //int result = Reference.Invoke("Hello World");
            //Console.WriteLine(result);

            #endregion

            #region Delegate Ex02
            //int[] numbers = { 9 , 8 , 7 , 6 , 5, 1, 2, 3 , 4 };
            //Bubble Sort

            //SortingAlgorithm.BubbleSort(numbers); // BubbleSortAscending

            //SortingAlgorithm.BubbleSortAscending(numbers); // BubbleSortAscending
            //SortingAlgorithm.BubbleSortDescending(numbers); //BubbleSortDescending

            //ConditionFuncDelegate Ref = SortingFunctions.CompareGtr;
            //SortingAlgorithm.BubbleSort(numbers , Ref); // BubbleSortAscending

            //Ref = SortingFunctions.CompareLess;

            //SortingAlgorithm.BubbleSort(numbers, Ref); // BubbleSortDescending

            //SortingAlgorithm.BubbleSort(numbers, SortingFunctions.CompareGtr); //BubbleSortAscending
            //SortingAlgorithm.BubbleSort(numbers, SortingFunctions.CompareLess); // BubbleSortDescending

            //foreach (int item in numbers)
            //{
            //    Console.Write(item + " ");
            //}




            //string[] names = { "Mahmoud","Ahmed","Ali", "omar", "Mariam", "Aya" };

            //SortingAlgorithm.BubbleSort(names, SortingFunctions.CompareGtr);   //BubbleSortAscending
            //SortingAlgorithm.BubbleSort(names, SortingFunctions.CompareLess);   // BubbleSortDescending


            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Delegate Ex03

            //List<int> list = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = FindOddNumber(list);
            //
            //foreach (int item in OddNumbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //
            //
            //List<int> EvenNumbers = FindEvenNumber(list);
            //
            //foreach (int item in EvenNumbers)
            //{
            //    Console.Write($"{item} ");
            //}
            //
            //
            //List<int> CheckDevisibleBy4 = DevisibleBy4(list);
            //
            //foreach (int item in CheckDevisibleBy4)
            //{
            //    Console.Write($"{item} ");
            //}

            //List<int> CheckDevisibleBy4 = FindNumber(list , ConditionFunctions.CheckDevisibleBy4);
            //List<int> CheckEven = FindNumber(list , ConditionFunctions.CheckEven);
            //List<int> Checkodd = FindNumber(list , ConditionFunctions.Checkodd);
            //
            //foreach (int item in CheckDevisibleBy4)
            //{
            //    Console.Write($"{item} ");
            //}


            //List<string> names = new List<string> { "Mahmoud", "Ahmed", "Ali", "omar", "Mariam", "Aya" };
            //
            //List<string> result = FindElements(names, ConditionFunctions.checkLength);
            //
            //
            //List<int> CheckDevisibleBy4 = FindElements(list , ConditionFunctions.CheckDevisibleBy4);
            //List<int> CheckEven = FindElements(list, ConditionFunctions.CheckEven);
            //List<int> Checkodd  = FindElements(list, ConditionFunctions.Checkodd);
            //
            //foreach (int item in CheckDevisibleBy4)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region Built-in Delegate
            //  predicate - Func - Action

            //1. predicate
            //Predicate<int> predicate = ConditionFunctions.CheckEven;

            // 2. Func

            // Func<int, bool> func = ConditionFunctions.Checkodd;
            // Func<string, string , bool> func1 = SortingFunctions.CompareGtr;

            // 3. Action

            //  Action action = ConditionFunctions.Welcome;
            //  action.Invoke();
            // 
            //  Action<string> action1 = ConditionFunctions.print;
            //  action1.Invoke("Hello");
            //  action1("hello");
            #endregion

            #region Anonymous Methods AndLambda Expression

            // Anonymous Methods
            // C# 2.0 feature [2005]

            // predicate
            // Predicate<int> predicate = ConditionFunctions.CheckEven;
            //Predicate<int> predicate = delegate (int x) { return x % 2 != 0; };  // Anonymous Methods
            //Predicate<int> predicate1 = delegate (int x) { return x % 2 == 0; };  // Anonymous Methods
            //
            //   predicate.Invoke(2);
            //   predicate(10); // syntax sugar

            // Lambda Expression or anther Name => (FatArrow)
            // C# 3.0 feature [2007]

            // Predicate<int> predicate2 = (int x) => { return x % 2 != 0; };  //  Lambda Expression
            // Predicate<int> predicate3 = x => x % 2 != 0; ;  //  Lambda Expression
            #endregion


            #region C# 3.0 -- Var Implicitly Type Locail Variable

            // C# 3.0 -- Var Implicitly Type Locail Variable
            // Predicate<int> predicate = ConditionFunctions.CheckEven;

            // var Predicate = ConditionFunctions.CheckEven;

            // var x = 12; 
            #endregion

            #region Function Returns Function 
            //var x = Fun01();
            //Action x = Fun01();
            //Fun01()();

            #endregion

        }
    }
    class StringFunctions
    {
        // Claa Member Methods
        public static int GetCountOfUpperCaseChar(string word)
        {
            int count = 0;

            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int GetCountOfLowerCaseChar(string word)
        {
            int count = 0;

            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

    class ConditionFunctions
    {

        public static bool Checkodd(int x) { return x % 2 != 0; }
        public static bool CheckEven(int x) { return x % 2 == 0; }
        public static bool CheckDevisibleBy4(int x) { return x % 4 == 0; }
        public static bool checkLength(string s) { return s?.Length > 3; }
        public static void Welcome() { Console.WriteLine("Hello World"); }
        public static void print(string s) { Console.WriteLine("Hello World"); }
    }

}