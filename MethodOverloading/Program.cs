namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static string Add(int number1, int number2, bool yesNo)
        {
            int sum = number1 + number2;

            if (yesNo == true)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return $"{sum}";
            }

        }

    static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            double c = 3.14259;
            double d = 12.2;
            bool isTrue = true;

            int integerAdd = Add(a, b);
            double decimalAdd = Add(c, d);
            string otherAdd = Add(a, b, isTrue);

            Console.WriteLine($"Int add = {integerAdd} | Decimal Add = {decimalAdd} | Text Add = {otherAdd}");




        }
    }
}
