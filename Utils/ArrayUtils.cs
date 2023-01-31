namespace MyUtilities
{

    public static class ArrayUtils
    {
        //Average & Mean
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
        public static int Sum(int[] Nums)
        {
            int sum = 0;
            foreach (int num in Nums)
            {
                sum += num;
            }
            return sum;
        }
        public static double Sum(double[] Nums)
        {
            double sum = 0;
            foreach (double num in Nums)
            {
                sum += num;
            }
            return sum;
        }
        public static int Product(int[] Nums)
        {
            int product = 1;
            foreach (int num in Nums)
            {
                product *= num;
            }
            return product;
        }
        public static double Product(double[] Nums)
        {
            double product = 1;
            foreach (double num in Nums)
            {
                product *= num;
            }
            return product;
        }

        public static int[] SortAscending(int[] Nums)
        {
            var n = Nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        var tempVar = Nums[j];
                        Nums[j] = Nums[j + 1];
                        Nums[j + 1] = tempVar;
                    }
                }
            }
            return Nums;
        }

        public static double[] SortAscending(double[] Nums)
        {
            var n = Nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        var tempVar = Nums[j];
                        Nums[j] = Nums[j + 1];
                        Nums[j + 1] = tempVar;
                    }
                }
            }
            return Nums;
        }

        public static int[] SortDescending(int[] Nums)
        {
            int temp = 0;
            int pass = 0;
            int loop = 0;
            for (pass = 0; pass <= Nums.Length - 2; pass++)
            {
                for (loop = 0; loop <= Nums.Length - 2; loop++)
                {
                    if (Nums[loop] < Nums[loop + 1])
                    {
                        temp = Nums[loop + 1];
                        Nums[loop + 1] = Nums[loop];
                        Nums[loop] = temp;
                    }
                }
            }
            return Nums;
        }

        public static double[] SortDescending(double[] Nums)
        {
            double temp = 0;
            int pass = 0;
            int loop = 0;
            for (pass = 0; pass <= Nums.Length - 2; pass++)
            {
                for (loop = 0; loop <= Nums.Length - 2; loop++)
                {
                    if (Nums[loop] < Nums[loop + 1])
                    {
                        temp = Nums[loop + 1];
                        Nums[loop + 1] = Nums[loop];
                        Nums[loop] = temp;
                    }
                }
            }
            return Nums;
        }

        //Range

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

        public static int[] Randomize(int[] nums)
        {
            Random randomNum = new Random();

            for (int i = nums.Length - 1; i > 0; --i)
            {
                int j = randomNum.Next(i + 1);
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            return nums;
        }

        public static double[] Randomize(double[] nums)
        {
            Random randomNum = new Random();

            for (int i = nums.Length - 1; i > 0; --i)
            {
                int j = randomNum.Next(i + 1);
                double temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            return nums;
        }

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
    }
}

