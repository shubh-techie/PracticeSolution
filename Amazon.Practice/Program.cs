using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Amazon.Practice
{
    class Program
    {
        private static void QuickSortDemostration()
        {
            int[] arr = { 10, 3, 2, 7, 7, 5, 8, 4, 1, 2, 9, 7, 8, 11 };
            //int[] arr = { -20, 2, 5, 3, 7, 5, 8, -4, 9, 23, 111 };
            // int[] arr = { 10, 20, 30, 50, 60, 40 };
            //int[] arr = { 3, 9, 1, 4, 7 };
            Console.WriteLine("Before sorting....");

            MergerSortDemo.PrintAnArray(arr);
            QuickSort.quickSorting(arr, 0, arr.Length - 1);

            Console.WriteLine("After sorting....");
            MergerSortDemo.PrintAnArray(arr);
        }
        static void Main(string[] args)
        {

            //connect ropes 
            ConnectRopes.mergeFiles();


            //SearchingDemostration();
            //MergerSortDemostration();
            //SelectionSortDemostration();
            //InsertionSortDemostration();
            //QuickSortDemostration();

            //SumOfTwoNumberPractice.TruckPackage();
            //SumOfTwoNumberPractice.makeAnagram("cde", "abc");

            //ArrayAndStraingsDemo();
            //printAnArrayUsingRecursion();
            //NonConsecutiveOnes(2);


            // two d array 
            //TwoDimensionArray();

            // bool isPermutation = CheckPermutation("hereiamstackerrank", "hackerworld");
            //Console.WriteLine();

            //Console.WriteLine(  hackerrankInString("hackerrank"));
            //// Console.WriteLine("Hello".Substring(1));
            //Console.WriteLine();


            //string compress = Compress("aabcccccaaa");
            //Console.WriteLine(compress);

            // Console.WriteLine(reverse(-1146467285));

            //int[] rob = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //Console.WriteLine(Rob(rob));

            //int[] arr = { 3, -7, 0 };
            //Console.WriteLine(minimumAbsoluteDifference(arr));


            //int truckSpace = 90;
            //int[] packagesSpace = { 1, 10, 25, 35, 60, 45, 15, 55, 88, 20, 40, 5 };
            //int[] result = findIdsOfPackages(packagesSpace, truckSpace);
            //Console.WriteLine("{0},{1}", result[0], result[1]);


            //HashSet<string> HS = new HashSet<string>();

            //for (int i = 0; i < 100; i++)
            //{
            //    if(!HS.Contains(i.ToString()))
            //    HS.Add(i.ToString());
            //}

            //for (int i = 0; i < HS.Count; i++)
            //{
            //    Console.WriteLine(HS.ToList()[i]);
            //}

            //int[] Arr = { 4, 2, 6, 5, 7, 9, 10 };
            //int sum = 13;
            //bool result = ExampleOfTwoSome.TwoSumUsingLoopingAllItems(Arr, Arr.Length, sum);
            //DateTime startTime = DateTime.Now;
            //Console.WriteLine("{0} :This Array has Two Candidates :{1} of sum :{2} in time ={3}", Arr, result, sum, DateTime.Now - startTime);


            //startTime = DateTime.Now;
            //bool resultFromSorting = ExampleOfTwoSome.TwoSumUsingSorting(Arr, Arr.Length, sum);
            //Console.WriteLine("{0} :This Array has Two Candidates :{1} of sum :{2} in time ={3}", Arr, resultFromSorting, sum, DateTime.Now - startTime);


            //startTime = DateTime.Now;
            //bool resultFromHashSet = ExampleOfTwoSome.TwoSumUsingHashSet(Arr, Arr.Length, sum);
            //Console.WriteLine("{0} :This Array has Two Candidates :{1} of sum :{2} in time ={3}", Arr, resultFromHashSet, sum, DateTime.Now - startTime);

            //int[] nums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
            //int[] resIndex = ExampleOfTwoSome.TwoSum(nums, 542);
            //pintArrayRec(resIndex);

            //FrequencyCount.findUniqueFromArray();
            //FrequencyCount.wordCountTesting();

            //FrequencyCount.rgbGesting();
            //FrequencyCount.missingNumberTesting();

            // FrequencyCount.anagramPairTesting();
            //FrequencyCount.letterSort();

            //FrequencyCount.characterMode();
            //FrequencyCount.anagramPalindromeTesting();

            //int n = a.Length;
            //SortingABinaryArray.sortBinaryArray(a, n);
            //pintArrayRec(a);


            Ques1304FindNUniqueIntegers.SumZero();
            Console.WriteLine("Please click <enter> to exit");
            Console.ReadLine();
        }


        public static List<int> findAllDuplicates(int[] arr)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map[arr[i]] = 1;
                }
                else
                {
                    if (map[arr[i]] == 1)
                    {
                        map[arr[i]] = 2;
                        result.Add(arr[i]);
                    }
                }
            }
            return result;
        }




        static int superDigit(string n, int k)
        {
            int intput = 0;
            for (int i = 0; i < n.Length; i++)
                intput += Convert.ToInt32(n[i].ToString());

            intput = intput * k;
            return superDigitHelper(new StringBuilder(intput.ToString()));
        }

        static int superDigitHelper(StringBuilder n)
        {
            if (n.Length == 1)
                return Convert.ToInt32(n[0].ToString());
            else
            {
                int sum = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    sum = sum + Convert.ToInt32(n[i].ToString());
                }

                return superDigitHelper(new StringBuilder(sum.ToString()));
            }
        }


        public static int[] sumclosest(int[] nums, int d)
        {
            int[] result = new int[2];
            if (nums == null || nums.Length == 0 || d < 30)
            {
                return result;
            }

            int max = Int32.MinValue;
            Array.Sort(nums);
            int i = 0; int j = nums.Length - 1;

            while (i < j)
            {
                if (nums[i] + nums[j] < d - 30)
                {
                    if ((nums[i] + nums[j]) > max)
                    {
                        max = nums[i] + nums[j];
                        result[0] = nums[i];
                        result[1] = nums[j];
                    }
                    i++;
                }
                else if (nums[i] + nums[j] > d - 30)
                {
                    j--;
                }
                else
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
            return result;
        }


        private static int[] findIdsOfPackages(int[] packagesSpace, int truckSpace)
        {
            int trackCapacity = truckSpace - 30;
            int[] result = new int[2] { -1, -1 };

            if (truckSpace < 30 && packagesSpace.Length < 2)
                return result;

            for (int i = 0; i < packagesSpace.Length; i++)
            {
                for (int j = i + 1; j < packagesSpace.Length; j++)
                {
                    if (packagesSpace[i] + packagesSpace[j] == trackCapacity)
                    {
                        if (result[0] == -1 && result[1] == -1)
                        {
                            result[0] = i;
                            result[1] = j;
                        }
                        else if (Math.Max(packagesSpace[i], packagesSpace[j]) > Math.Max(packagesSpace[result[0]], packagesSpace[result[1]]))
                        {
                            result[0] = i;
                            result[1] = j;
                        }
                    }
                }
            }
            return result;
        }

        static int minimumAbsoluteDifference(int[] arr)
        {

            int diff = Math.Abs(arr[0] - arr[1]);
            Console.WriteLine("diff  :" + diff);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int addabs = Math.Abs(arr[i] + arr[i + 1]);
                if (diff > addabs)
                {
                    diff = addabs;
                }
            }

            Queue storage = new Queue();

            return diff;

        }

        public static int Rob(int[] nums)
        {
            int[] memo = new int[nums.Length + 1];
            return HouseThief(nums, 0, memo);
        }

        public static int HouseThief(int[] nums, int currentIndex, int[] memo)
        {
            if (currentIndex >= nums.Length)
                return 0;

            if (memo[currentIndex] >= 0)
            {
                return memo[currentIndex];
            }

            int currentIndexThief = nums[currentIndex] + HouseThief(nums, currentIndex + 2, memo);
            int skipIndexThief = HouseThief(nums, currentIndex + 1, memo);

            int result = Math.Max(currentIndexThief, skipIndexThief);
            memo[currentIndex] = result;
            Console.Write(result);
            Console.WriteLine();
            return result;
        }
        public static int reverse(int A)
        {

            if (A > Int32.MaxValue && A < Int32.MinValue)
                return 0;

            string number = Convert.ToString(A);
            string output = "";

            for (int i = 0; i < number.Length; i++)
            {
                output = number[i] + output;
            }


            return Int32.Parse(output[output.Length - 1] == '-' ? "-" + output.TrimEnd('-') : output);
        }

        private static string Compress(string strCompress)
        {

            StringBuilder compressBuiler = new StringBuilder();
            int countConsecutive = 0;


            for (int i = 0; i < strCompress.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= strCompress.Length || strCompress[i] != strCompress[i + 1])
                {
                    compressBuiler.Append(strCompress[i]);
                    compressBuiler.Append(countConsecutive);
                    countConsecutive = 0;
                }


            }

            return compressBuiler.Length < strCompress.Length ? compressBuiler.ToString() : strCompress;

        }


        static string hackerrankInString(string s)
        {
            string possible = "NO";
            string hacker = "hackerrank";
            int hackTrack = 0;

            if (s.Length < hacker.Length)
            {
                return possible;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString() == hacker[hackTrack].ToString())
                {
                    hackTrack++;
                }
            }

            if (hackTrack == hacker.Length)
            {
                possible = "YES";
            }


            return possible;
        }

        private static bool CheckPermutation(string s, string t)
        {
            bool isPermutation = false;
            //if (s.Length != t.Length)
            //{
            //    return isPermutation;
            //}

            int[] letters = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                letters[s[i]]++;
            }
            pintArrayRec(letters);

            for (int i = 0; i < t.Length; i++)
            {
                letters[t[i]]--;

                if (letters[t[i]] < 0)
                {
                    isPermutation = false;
                }
            }
            Console.WriteLine();
            pintArrayRec(letters);

            return isPermutation;
        }

        private static void TwoDimensionArray()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 8 };
            int noOfPair = nums.Length % 2 == 0 ? nums.Length / 2 : nums.Length / 2 + 1;
            int[,] array2D = new int[noOfPair, 2];

            MakeAPair(nums, 0, array2D);
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.WriteLine("{");
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.WriteLine(array2D[i, j] + ",");
                }
                Console.WriteLine("}");
            }

        }

        private static void MakeAPair(int[] nums, int index, int[,] result)
        {

            if (index >= nums.Length)
                return;

            result[index / 2, 0] = nums[index];
            if (index + 1 < nums.Length)
                result[index / 2, 1] = nums[index + 1];
            else
                result[index / 2, 1] = -1;

            MakeAPair(nums, index + 2, result);
        }

        private static void printAnArrayUsingRecursion()
        {
            int[] arr = { 3, 4354, 345435, 435435, 435435, 345435, 657, 345, 6767 };
            pintArrayRec(arr);
        }

        private static void pintArrayRec(int[] arr)
        {
            helerRec(arr, 0);
        }

        private static void helerRec(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                return;
            }
            if (arr[index] != 0)
                Console.Write(arr[index] + " ");
            helerRec(arr, index + 1);
        }

        private static List<string> NonConsecutiveOnes(int n)
        {
            List<string> allCombination = new List<string>();

            NonConHelper(allCombination, "", n);


            foreach (var item in allCombination)
            {
                Console.WriteLine(item);
            }
            return allCombination;
        }

        private static void NonConHelper(List<string> allCombination, string str, int n)
        {
            if (str.Length == n)
            {
                allCombination.Add(str);
                return;
            }
            Console.WriteLine(str);
            NonConHelper(allCombination, str + 0, n);

            if (str[str.Length - 1].ToString() != "1")
            {
                NonConHelper(allCombination, str + 1, n);
            }
        }

        private static List<string> HelperRecursion(string str, int n)
        {
            List<string> allStr = new List<string>();

            if (str.Length == 0)
                str = str + 0;

            if (str.Length == n)
            {
                allStr.Add(str);
                return allStr;
            }
            return allStr;
        }

        public static List<int> unique(int[] arr)
        {

            List<int> _names = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!_names.Contains(arr[i]))
                    _names.Add(arr[i]);
            }

            // YOUR WORK HERE
            return _names;
        }


        private static void ArrayAndStraingsDemo()
        {
            // ArrayAndStraings.HashtableDemo();
            ArrayAndStraings.ArrayListDemo();
        }



        private static void InsertionSortDemostration()
        {
            int[] arr = { 4, 8, 5, 3, 9, 2, 4, 5, 1 };

            MergerSortDemo.PrintAnArray(arr);
            InsertionSort.insertionSort(arr);
            MergerSortDemo.PrintAnArray(arr);
        }

        private static void SelectionSortDemostration()
        {
            int[] arr = { 4, 8, 5, 3, 9, 2, 4, 5, 1 };

            MergerSortDemo.PrintAnArray(arr);
            SelectionSort.selectionSort(arr, arr.Length);
            MergerSortDemo.PrintAnArray(arr);
        }

        private static void MergerSortDemostration()
        {
            int[] arr = { 4, 8, 5, 3, 9, 2, 4, 5, 1 };

            MergerSortDemo.Mergersort(arr, arr.Length);
            MergerSortDemo.PrintAnArray(arr);
        }

        private static void SearchingDemostration()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var index = SearchingDemo.BinarySearch(arr, 12);
            var index = SearchingDemo.BinarySearchRecursive(arr, 0, arr.Length - 1, 12);

            Console.WriteLine("Here is the index : {0}", index);


        }

        public static int minimumStepsToOne(int num)
        {
            int minStepsToOne = 0;

            while (num > 1)
            {
                if (num % 2 == 0)
                    num = num / 2;
                else if (num % 3 == 1)
                    num = num / 3;
                else
                    num = num - 1;

                minStepsToOne++;
            }

            return minStepsToOne;
        }

        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> anagram = new List<int>();
            int count = 0;

            for (int i = 0; i < query.Count; i++)
            {
                count = 0;
                for (int j = 0; j < dictionary.Count; j++)
                {
                    if (isAnagram(query[i], dictionary[j]))
                    {
                        Console.WriteLine(query[i] + " " + dictionary[j]);
                        count++;
                    }
                }
                anagram.Add(count);
            }


            //foreach (var que in query)
            //{
            //    count = 0;
            //    foreach (var dic in dictionary)
            //    {
            //        if (isAnagram(que, dic))
            //        {
            //            count++;
            //            anagram.Add(count);
            //        }
            //    }
            //}


            return anagram;
        }

        public static bool isAnagram(string query, string dic)
        {
            if (query.Length != dic.Length)
                return false;


            var queryArr = query.ToLower().ToCharArray();
            var dicArr = dic.ToLower().ToCharArray();


            Array.Sort(queryArr);
            Array.Sort(dicArr);

            query = new string(queryArr);
            dic = new string(dicArr);

            return query == dic;
        }

    }
}


///*

///3
///2
//-1

//Greedy Approach

//5 -> 4 -> 2 -> 1    3 steps
//5 -> 4 -> 3 -> 1    3 steps


//10 -> 5 -> 4 -> 2 -> 1        4 steps
//10 -> 9 -> 3 -> 1             3 steps





//Recursion


//                                            10 (3)
//                        /                                       \
//                      9 (2)                                        5(3)
//              /                       \                                     \
//            8                          3  (1)                                 4(2)
//        /           \           /           \                             /         \
//       7              4        2 (option:1)  1 (divide3:0)                       2(1)          3(1)
//      /                       /   \                                   /     \       /     \
//    6                        1     1                                 1 (0)   1(0)  2(1)    1(0)
//  / | \
// 5  3  2



//1 => 0
//2 => 1

//*/

//// O(k^N)
////
//// N = input
//// k = ~~1 + 1/2 + 1/3
//function minimumStepsToOne(num)
//{
//    function traverse(current)
//    {
//        if (current === 1)
//        {
//            return 0;
//        }

//        // subtract 1
//        let option = traverse(current - 1);

//        // divide by 3
//        if (current % 3 === 0)
//        {
//            let divide3 = traverse(current / 3);
//            option = Math.min(option, divide3);
//        }

//        // divide by 2
//        if (current % 2 === 0)
//        {
//            let divide2 = traverse(current / 2);
//            option = Math.min(option, divide2);
//        }

//        return option + 1;
//    }

//    return traverse(num);
//}





//// console.time("RECURSION: ");
//// console.log(minimumStepsToOne(600));
//// console.timeEnd("RECURSION: ");




///*

//Memoization

//{
//  2: 1
//  3: 1
//  4: 2
//  5: 3
//}

//                            10 (3)
//                        /                    \
//                      9 (2)                     5(3)
//              /                  \                                 
//            8                    3  (1)                             
//        /           \                                   
//       7              4  (2)               
//      /                                                                            
//    6                                                                             
//  / | \
// 5  3  2



//call stack = [(100,000) (99,999) (99,998) .............. (1)]


//*/

//// 1) Create cache
//// 2) Check cache
//// 3) Write to cache

//// O(N)
//let cache = { };

//function minimumStepsToOneMemo(num)
//{
//    function traverse(current)
//    {
//        if (current in cache) {
//        return cache[current];
//    }
//    if (current === 1)
//    {
//        return 0;
//    }

//    // subtract 1
//    let option = traverse(current - 1);

//    // divide by 3
//    if (current % 3 === 0)
//    {
//        let divide3 = traverse(current / 3);
//        option = Math.min(option, divide3);
//    }

//    // divide by 2
//    if (current % 2 === 0)
//    {
//        let divide2 = traverse(current / 2);
//        option = Math.min(option, divide2);
//    }

//    cache[current] = option + 1;
//    return option + 1;
//}

//  return traverse(num);
//}






///*

//Tabulation



//      0   1 2 3 4 5 6 7 8 9 10
//    [null,0,1,1
//                            ^

//call stack = [()]

//*/



//let result = new Array(600 + 1);

//function l(num)
//{
//    if (result[num] !== undefined)
//    {
//        return result[num];
//    }
//    result[1] = 0;

//    for (let i = 2; i < result.length; i++)
//    {
//        // subtract 1
//        let option = result[i - 1];

//        // divide by 3
//        if (i % 3 === 0)
//        {
//            let divide3 = result[i / 3];
//            option = Math.min(option, divide3);
//        }

//        // divide by 2
//        if (i % 2 === 0)
//        {
//            let divide2 = result[i / 2];
//            option = Math.min(option, divide2);
//        }

//        result[i] = option + 1;
//    }

//    return result[num];
//}


//// console.time("MEMOIZATION: ");
//// console.log(minimumStepsToOneMemo(600));
//// console.timeEnd("MEMOIZATION: ");


//// console.time("TABULATION: ");
//// console.log(minimumStepsToOneTab(600));
//// console.timeEnd("TABULATION: ");


//console.time("MEMOIZATION MANY: ");
//for (let i = 0; i< 1000; i++) {
//  minimumStepsToOneMemo(600);
//}
//console.timeEnd("MEMOIZATION MANY: ");


//console.time("TABULATION MANY: ");
//for (let i = 0; i< 1000; i++) {
//  minimumStepsToOneTab(600);
//}
//console.timeEnd("TABULATION MANY: ");

