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

            foreach(int num in Nums){
                sum +=num;
                length++;
            }
            average = sum/length;
            return average;
        }
        public static double Average(double[]Nums)
        {
            double average = 0;
            double sum = 0;
            double length = 0;

            foreach(double num in Nums){
                sum +=num;
                length++;
            }
            average = sum/length;
            return average;
        }
        public static int Mean(int[] Nums)
        {
            int mean = 0;
            int sum = 0;
            int length = 0;

            foreach(int num in Nums){
                sum +=num;
                length++;
            }
            mean = sum/length;
            return mean;
        }
        public static double Mean(double[]Nums)
        {
            double mean = 0;
            double sum = 0;
            double length = 0;

            foreach(double num in Nums){
                sum +=num;
                length++;
            }
            mean = sum/length;
            return mean;
        }
        // Max & Min
        public static int Max(int[]Nums)
        {
            int Max = 1;
            foreach(int num in Nums){
                if(num > Max){
                    Max = num;
                }
            }
            return Max;
        }
        public static double Max(double[]Nums)
        {
            double Max = 1;
            foreach(double num in Nums){
                if(num>Max){
                    Max=num;
                }
            }
            return Max;
        }
        public static int Min(int[]Nums)
        {
            int Min = Nums[0];
            foreach(int num in Nums){
                if(num<Min){
                    Min=num;
                }
            }
            return Min;
        }
        public static double Min(double[]Nums)
        {
            double Min = Nums[0];
            foreach(double num in Nums){
                if(num<Min){
                    Min=num;
                }
            }
            return Min;
        }



        //Sum & Product
        public static int Sum(int[]Nums)
        {
           int sum = 0;
           foreach(int num in Nums){
            sum +=num;
           }
           return sum;
        }
        public static double Sum(double[]Nums)
        {
            double sum =0;
            foreach(double num in Nums){
                sum += num;
            }
            return sum;
        }
        public static int Product(int[]Nums)
        {
            int product = 1;
            foreach(int num in Nums){
                product *= num;
            }
            return product;
        }
        public static double Product(double[]Nums)
        {
            double product = 1;
            foreach(double num in Nums){
                product *= num;
            }
            return product;
        }

        //Sorting

        
    }

}