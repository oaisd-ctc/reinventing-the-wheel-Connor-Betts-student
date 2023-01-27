namespace MyUtilities
{

    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(StringUtils.HasLetter("Hello, my name is corey", "friend"));

            int[] Nums = {1,2,3,4,5};

            Console.WriteLine(MathUtils.SquareRoot(145));
            Console.WriteLine(ArrayUtils.Range(Nums));

        }



    }

}
