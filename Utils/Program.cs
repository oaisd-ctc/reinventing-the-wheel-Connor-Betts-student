﻿namespace MyUtilities
{

    public static class Program
    {

        public static void Main(string[] args)
        {
            //Console.WriteLine(StringUtils.HasLetter("Hello, my name is corey", "friend"));

            int[] Nums = {6, 2, 3, 4, 524, 90, 7};


           //Console.WriteLine(MathUtils.SquareRoot(145));
            ArrayUtils.SortAscending(Nums);
            Console.WriteLine(ArrayUtils.HasNumber(Nums, 124));
            Console.WriteLine(MathUtils.Subtract(1, 2));
            MathUtils.Add(2.0, 1.0);
            


        }



    }

}
