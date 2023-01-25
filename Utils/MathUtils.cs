namespace MyUtilities
{

    public static class MathUtils
    {
        
        //Addition
        public static int Add(int x, int y)
        {
            return x+y;
        }

        public static double Add(double x, double y)
        {
            return x+y;
        }

        public static float Add(float x, float y)
        {
            return x+y;
        }

        //Subtraction

        public static int Subtract(int x, int y)
        {
            return x-y;
        }

        public static double Subtract(double x, double y)
        {
            return x-y;
        }
        public static float Subtract(float x, float y)
        {
            return x-y;
        }

        //Multiplication

        public static int Multiply(int x, int y)
        {
            return x*y;
        }
        public static double Multiply(double x, double y)
        {
            return x*y;
        }
        public static float Multiply(float x, float y)
        {
            return x*y;
        }

        //Division
        public static int Divide(int x, int y)
        { 
            return x/y;
        }
        public static double Divide(double x, double y)
        {
            return x/y;
        }
        public static float Divide(float x, float y)
        {
            return x/y;
        }

        //Squared
        public static int Squared(int x)
        {
            return x*x;
        }
        public static double Squared(double x)
        {
            return x*x;
        }
        public static float Squared(float x)
        {
            return x*x;
        }

        //Cubed

        public static int Cubed(int x)
        {
            return x*x*x;
        }
        public static double Cubed(double x)
        {
            return x*x*x;
        }
        public static float Cubed(float x)
        {
            return x*x*x;
        }

        //Power

        public static int Power(int a, int n)
        {
            int result =1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
                return result;

        }
        public static double Power(double a, double n)
        {
             double result = 1;
            for(int i = 0; i<n; i++)
            {
                result *= a;
            }
            return result;
        }
        public static float Power(float a, float n)
        {
            float result = 1;
            for (int i = 0; i<n; i++)
            {
                result *= a;
            }
            return result;
        }

        //Min

        public static int Min(int x, int y)
        {
            int result = 0;
            if (x > y){
                result =  y;
            } else if (x < y){
               result = x;
            } else if (x==y){
                result =x;
            }
            return result;
        }
        public static double Min(double x, double y)
        {
            double result = 0;
            if (x > y){
                result =  y;
            } else if (x < y){
               result = x;
            } else if (x==y){
                result =x;
            }
            return result;
        }
        public static float Min(float x, float y)
        {
            float result = 0;
            if (x > y){
                result =  y;
            } else if (x < y){
               result = x;
            } else if (x==y){
                result =x;
            }
            return result;
        }

        //Max

        public static int Max(int x, int y)
        {
            int result = 0;
            if (x < y){
                result =  y;
            } else if (x > y){
               result = x;
            } else if (x==y){
                result =x;
            }
            return result;
        }
        public static double Max(double x, double y)
        {
           double result = 0;
            if (x < y){
                result =  y;
            } else if (x > y){
               result = x;
            } else if (x==y){
                result =x;
            }
            return result;
        }
        public static float Max(float x, float y)
        {
             float result = 0;
            if (x < y){
                result =  y;
            } else if (x > y){
               result = x;
            } else if (x==y){
                result =x;
            }
            return result;
        }

        //Absolute value
        public static int AbsoluteValue(int x)
        {
            int result = 0;
            if (x>0){
                result = x*-1;
            } else if (x > 0){
                result = x;
            }
            return result;
        }
        public static double AbsoluteValue(double x){
             double result = 0;
            if (x>0){
                result = x*-1;
            } else if (x > 0){
                result = x;
            }
            return result;
        }
        public static float AbsoluteValue(float x)
        {
            float result = 0;
            if (x>0){
                result = x*-1;
            } else if (x > 0){
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
            if (x > y){
                large = x;
                small = y;
            } else if (y > x){
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
            if(x>y){
                large=x;
                small=y;
            } else if(y>x){
                large=y;
                small=x;
            }
            result = large-small;
            return result;
        }
        public static float Difference(float x, float y)
        {
            float large = 0;
            float small = 0;
            float result = 0;
            if(x>y){
                large=x;
                small=y;
            } else if(y>x){
                large=y;
                small=x;
            }
            result = large-small;
            return result;
        }

        //Square Root
        public static int SquareRoot(int x)
        {
            int root = 1;
            int i = 0;
            while(true)
            {
                i = i+1;
                root = (x / root + root) / 2;
                if (i== x +1) {break; }
            }
            return root;
        }
        public static double SquareRoot(double x)
        {
            double root = 1;
            int i = 0;
            while(true)
            {
                i = i+1;
                root = (x / root + root) / 2;
                if (i== x +1) {break; }
            }
            return root;
        }
        public static float SquareRoot(float x)
        {
            float root = 1;
            int i = 0;
            while(true)
            {
                i = i+1;
                root = (x / root + root) / 2;
                if (i== x +1) {break; }
            }
            return root;
        }

        //Percent

        public static double Percent(double x)
        {
            return x*100;
        }
        public static float Percent(float x)
        {
            return x*100;
        }
        public static decimal Percent(decimal x)
        {
            return x*100;
        }

        

    }

}