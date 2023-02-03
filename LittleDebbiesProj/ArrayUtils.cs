namespace MyUtilities
{

    public static class ArrayUtils
    {
        //Average & Mean

        /// <summary>
        /// Finds the average of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Average of the array
        /// </returns>

        public static int Average(int[] Nums)
        {
            int average = 0;
            int sum = 0;
            int length = 0;

            foreach (int num in Nums)
            {
                sum += num;
                length++;
            }
            average = sum / length;
            return average;
        }

        /// <summary>
        /// Finds the average of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Average of the array
        /// </returns>
        public static double Average(double[] Nums)
        {
            double average = 0;
            double sum = 0;
            double length = 0;

            foreach (double num in Nums)
            {
                sum += num;
                length++;
            }
            average = sum / length;
            return average;
        }

        /// <summary>
        /// Finds the mean of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Mean of the array
        /// </returns>
        public static int Mean(int[] Nums)
        {
            int mean = 0;
            int sum = 0;
            int length = 0;

            foreach (int num in Nums)
            {
                sum += num;
                length++;
            }
            mean = sum / length;
            return mean;
        }

        /// <summary>
        /// Finds the mean of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Mean of the array
        /// </returns>
        public static double Mean(double[] Nums)
        {
            double mean = 0;
            double sum = 0;
            double length = 0;

            foreach (double num in Nums)
            {
                sum += num;
                length++;
            }
            mean = sum / length;
            return mean;
        }
        // Max & Min

        /// <summary>
        /// Finds the max of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Max of the array
        /// </returns>
        public static int Max(int[] Nums)
        {
            int Max = 1;
            foreach (int num in Nums)
            {
                if (num > Max)
                {
                    Max = num;
                }
            }
            return Max;
        }

        /// <summary>
        /// Finds the max of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Max of the array
        /// </returns>
        public static double Max(double[] Nums)
        {
            double Max = 1;
            foreach (double num in Nums)
            {
                if (num > Max)
                {
                    Max = num;
                }
            }
            return Max;
        }

        /// <summary>
        /// Finds the min of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Min of the array
        /// </returns>
        public static int Min(int[] Nums)
        {
            int Min = Nums[0];
            foreach (int num in Nums)
            {
                if (num < Min)
                {
                    Min = num;
                }
            }
            return Min;
        }

        /// <summary>
        /// Finds the min of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Min of the array
        /// </returns>
        public static double Min(double[] Nums)
        {
            double Min = Nums[0];
            foreach (double num in Nums)
            {
                if (num < Min)
                {
                    Min = num;
                }
            }
            return Min;
        }



        //Sum & Product

        /// <summary>
        /// Finds the total sum of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Total sum of the array
        /// </returns>
        public static int Sum(int[] Nums)
        {
            int sum = 0;
            foreach (int num in Nums)
            {
                sum += num;
            }
            return sum;
        }

        /// <summary>
        /// Finds the total sum of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Total sum of the array
        /// </returns>
        public static double Sum(double[] Nums)
        {
            double sum = 0;
            foreach (double num in Nums)
            {
                sum += num;
            }
            return sum;
        }

        /// <summary>
        /// Finds the total product of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Total product of the array
        /// </returns>
        public static int Product(int[] Nums)
        {
            int product = 1;
            foreach (int num in Nums)
            {
                product *= num;
            }
            return product;
        }

        /// <summary>
        /// Finds the total product of an array of numbers
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// Total product of the array
        /// </returns>
        public static double Product(double[] Nums)
        {
            double product = 1;
            foreach (double num in Nums)
            {
                product *= num;
            }
            return product;
        }

        /// <summary>
        /// Sorts the numbers in an array from least to greatest
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The numbers in ascending order
        /// </returns>

        public static int[] SortAscending(int[] Nums)
        {
            int temp;
            for (int j = 0; j <= Nums.Length - 2; j++)
            {
                for (int i = 0; i <= Nums.Length - 2; i++)
                {
                    if (Nums[i] > Nums[i + 1])
                    {
                        temp = Nums[i + 1];
                        Nums[i + 1] = Nums[i];
                        Nums[i] = temp;
                    }
                }
            }
            return Nums;
        }

        /// <summary>
        /// Sorts the numbers in an array from least to greatest
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The numbers in ascending order
        /// </returns>

        public static void SortAscending(double[] Nums)
        {
            double temp;
            double length = Nums.Length;
            for (double j = 0; j <= length - 2; j++)
            {
                for (int i = 0; i <= length - 2; i++)
                {
                    if (Nums[i] > Nums[i + 1])
                    {
                        temp = Nums[i + 1];
                        Nums[i + 1] = Nums[i];
                        Nums[i] = temp;
                    }
                }
            }
            foreach (double n in Nums)
            {
                Console.Write(n + " ");
            }
        }

        /// <summary>
        /// Sorts the numbers in an array from greatest to least
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The numbers in decending order
        /// </returns>

        public static int[] SortDescending(int[] num)
        {
            int temp = 0;

            int pass = 0;
            int loop = 0;

            for (pass = 0; pass <= num.Length - 2; pass++)
            {
                for (loop = 0; loop <= num.Length - 2; loop++)
                {
                    if (num[loop] < num[loop + 1])
                    {
                        temp = num[loop + 1];
                        num[loop + 1] = num[loop];
                        num[loop] = temp;
                    }
                }
            }
            return num;
        }

        /// <summary>
        /// Sorts the numbers in an array from greatest to least
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The numbers in decending order
        /// </returns>


        public static void SortDescending(double[] num)
        {
            double temp = 0;

            double pass = 0;
            int loop = 0;

            for (pass = 0; pass <= num.Length - 2; pass++)
            {
                for (loop = 0; loop <= num.Length - 2; loop++)
                {
                    if (num[loop] < num[loop + 1])
                    {
                        temp = num[loop + 1];
                        num[loop + 1] = num[loop];
                        num[loop] = temp;
                    }
                }
            }
            foreach (double n in num)
            {
                Console.Write(n + " ");
            }
        }

        //Range

        /// <summary>
        /// Finds the range of an array
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The range of the array
        /// </returns>



        public static int Range(int[] Nums)
        {
            int Min = Nums[0];
            int Max = 0;
            int range = 0;
            foreach (int num in Nums)
            {
                if (num < Min)
                {
                    Min = num;
                }
                if (num > Max)
                {
                    Max = num;
                }
            }
            range = Max - Min;
            return range;

        }

        /// <summary>
        /// Finds the mode of an array
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The mode of the array
        /// </returns>



        public static int Mode(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int a in nums)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
            }
            return result;
        }

        /// <summary>
        /// Finds the mode of an array
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <returns>
        /// The mode of the array
        /// </returns>

        public static int Mode(double[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int a in nums)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
            }
            return result;
        }

        /// <summary>
        /// Checks an array for a certain number
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <param name="p">The integer.</param>
        /// <returns>
        /// Returns true if the number was found, returns false if the number was not found
        /// </returns>

        public static bool HasNumber(int[] nums, int p)
        {
            int l = nums.Length;
            int f = 0;
            for (int i = 0; i < l; i++)
            {
                if (nums[i] == p)
                {
                    f++;
                }
            }
            if (f == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks an array for a certain number
        /// </summary>
        /// <param name="Nums">The Array.</param>
        /// <param name="p">The integer.</param>
        /// <returns>
        /// Returns true if the number was found, returns false if the number was not found
        /// </returns>


        public static bool HasNumber(double[] nums, double p)
        {
            int l = nums.Length;
            double f = 0;
            for (int i = 0; i < l; i++)
            {
                if (nums[i] == p)
                {
                    f++;
                }
            }
            if (f == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

