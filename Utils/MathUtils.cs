namespace MyUtilities
{

    public static class MathUtils
    {

        /// <summary>
        /// Adds two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x+y
        /// </returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Adds two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x+y
        /// </returns>
        public static double Add(double x, double y)
        {
            return x + y;
        }

        /// <summary>
        /// Adds two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x+y
        /// </returns>
        public static float Add(float x, float y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtracts two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x-y
        /// </returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Subtracts two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x-y
        /// </returns>
        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        /// <summary>
        /// Subtracts two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x-y
        /// </returns>
        public static float Subtract(float x, float y)
        {
            return x - y;
        }

        //Multiplication

        /// <summary>
        /// Multiplies two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x*y
        /// </returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Multiplies two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x*y
        /// </returns>
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Multiplies two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x*y
        /// </returns>
        public static float Multiply(float x, float y)
        {
            return x * y;
        }

        //Division

        /// <summary>
        /// Divides two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x/y
        /// </returns>
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        /// <summary>
        /// Divides two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x/y
        /// </returns>
        public static double Divide(double x, double y)
        {
            return x / y;
        }

        /// <summary>
        /// Divides two inputs
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// x/y
        /// </returns>
        public static float Divide(float x, float y)
        {
            return x / y;
        }

        //Squared

        /// <summary>
        /// Squares an input
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <returns>
        /// x^2
        /// </returns>
        public static int Squared(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Squares an input
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <returns>
        /// x^2
        /// </returns>
        public static double Squared(double x)
        {
            return x * x;
        }

        /// <summary>
        /// Squares an input
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <returns>
        /// x^2
        /// </returns>
        public static float Squared(float x)
        {
            return x * x;
        }

        //Cubed

        /// <summary>
        /// Cubes an input
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <returns>
        /// x^3
        /// </returns>
        public static int Cubed(int x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Cubes an input
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <returns>
        /// x^3
        /// </returns>
        public static double Cubed(double x)
        {
            return x * x * x;
        }

        /// <summary>
        /// Cubes an input
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <returns>
        /// x^3
        /// </returns>
        public static float Cubed(float x)
        {
            return x * x * x;
        }

        //Power

        /// <summary>
        /// Rasies a to the nth power
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="n">The second number.</param>
        /// <returns>
        /// a^n
        /// </returns>
        public static int Power(int a, int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            return result;
        }

        /// <summary>
        /// Rasies a to the nth power
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="n">The second number.</param>
        /// <returns>
        /// a^n
        /// </returns>
        public static double Power(double a, double n)
        {
            double result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            return result;
        }

        /// <summary>
        /// Rasies a to the nth power
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="n">The second number.</param>
        /// <returns>
        /// a^n
        /// </returns>
        public static float Power(float a, float n)
        {
            float result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            return result;
        }

        //Min

        /// <summary>
        /// Finds the smaller number
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// smallest number
        /// </returns>

        public static int Min(int x, int y)
        {
            int result = 0;
            if (x > y)
            {
                result = y;
            }
            else if (x < y)
            {
                result = x;
            }
            else if (x == y)
            {
                result = x;
            }
            return result;
        }

        /// <summary>
        /// Finds the smaller number
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// smallest number
        /// </returns>
        public static double Min(double x, double y)
        {
            double result = 0;
            if (x > y)
            {
                result = y;
            }
            else if (x < y)
            {
                result = x;
            }
            else if (x == y)
            {
                result = x;
            }
            return result;
        }

        /// <summary>
        /// Finds the smaller number
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// smallest number
        /// </returns>
        public static float Min(float x, float y)
        {
            float result = 0;
            if (x > y)
            {
                result = y;
            }
            else if (x < y)
            {
                result = x;
            }
            else if (x == y)
            {
                result = x;
            }
            return result;
        }

        //Max

        /// <summary>
        /// Finds the largest number
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// largest number
        /// </returns>
        public static int Max(int x, int y)
        {
            int result = 0;
            if (x < y)
            {
                result = y;
            }
            else if (x > y)
            {
                result = x;
            }
            else if (x == y)
            {
                result = x;
            }
            return result;
        }
        /// <summary>
        /// Finds the largest number
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// largest number
        /// </returns>
        public static double Max(double x, double y)
        {
            double result = 0;
            if (x < y)
            {
                result = y;
            }
            else if (x > y)
            {
                result = x;
            }
            else if (x == y)
            {
                result = x;
            }
            return result;
        }
        /// <summary>
        /// Finds the largest number
        /// </summary>
        /// <param name="x">The first number.</param>
        /// <param name="y">The second number.</param>
        /// <returns>
        /// largest number
        /// </returns>
        public static float Max(float x, float y)
        {
            float result = 0;
            if (x < y)
            {
                result = y;
            }
            else if (x > y)
            {
                result = x;
            }
            else if (x == y)
            {
                result = x;
            }
            return result;
        }

        //Absolute value
        public static int AbsoluteValue(int x)
        {
            int result = 0;
            if (x < 0)
            {
                result = x * -1;
            }
            else if (x > 0)
            {
                result = x;
            }
            return result;
        }
        public static double AbsoluteValue(double x)
        {
            double result = 0;
            if (x < 0)
            {
                result = x * -1;
            }
            else if (x > 0)
            {
                result = x;
            }
            return result;
        }
        public static float AbsoluteValue(float x)
        {
            float result = 0;
            if (x < 0)
            {
                result = x * -1;
            }
            else if (x > 0)
            {
                result = x;
            }
            return result;
        }

        //Difference
        public static int Difference(int x, int y)
        {
            int large = 0;
            int small = 0;
            int result = 0;
            if (x > y)
            {
                large = x;
                small = y;
            }
            else if (y > x)
            {
                large = y;
                small = x;
            }
            result = large - small;
            return result;
        }
        public static double Difference(double x, double y)
        {
            double large = 0;
            double small = 0;
            double result = 0;
            if (x > y)
            {
                large = x;
                small = y;
            }
            else if (y > x)
            {
                large = y;
                small = x;
            }
            result = large - small;
            return result;
        }
        public static float Difference(float x, float y)
        {
            float large = 0;
            float small = 0;
            float result = 0;
            if (x > y)
            {
                large = x;
                small = y;
            }
            else if (y > x)
            {
                large = y;
                small = x;
            }
            result = large - small;
            return result;
        }

        //Square Root
        public static int SquareRoot(int x)
        {
            int root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (x / root + root) / 2;
                if (i == x + 1) { break; }
            }
            return root;
        }
        public static double SquareRoot(double x)
        {
            double root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (x / root + root) / 2;
                if (i == x + 1) { break; }
            }
            return root;
        }
        public static float SquareRoot(float x)
        {
            float root = 1;
            int i = 0;
            while (true)
            {
                i = i + 1;
                root = (x / root + root) / 2;
                if (i == x + 1) { break; }
            }
            return root;
        }

        //Percent

        public static double Percent(double x)
        {
            return x * 100;
        }
        public static float Percent(float x)
        {
            return x * 100;
        }
        public static decimal Percent(decimal x)
        {
            return x * 100;
        }



    }

}