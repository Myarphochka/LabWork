namespace ConsoleApp1
{
    internal class Functions
    {
        public static void GetAbsolute(ref int x)
        {
            if (x < 0)
                x = -x;
        }

        public static void Sum(int a, int b, out int result)
        {
            result = a + b;
        }

        public static int GetSum(params int[] numbers)
        {
            int result = 0;
            foreach (var number in numbers)
                result += number;
            return result;
        }

        // без параметров
        public static int Sum(int a, int b) => a + b; // Sum(int, int)

        public static double Sum(double a, double b) => a + b; // Sum(double, double)

        public static int Sum(int a, int b, int c) => a + b + c; //Sum(int, int, int)
    }
}
