namespace MethodOverloading
{
    public class Program
    {
        static int Add(int number1, int number2){
            return(number1+number2);
        }
        static double Add(double number1, double number2){
            return(number1+number2);
        }

        static string Add(int number1, int number2, bool dollars){
            string sum = (number1 + number2).ToString();
            return(dollars ? (sum == "1" ? $"{sum} dollar" : $"{sum} dollars") : sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2, true));
            Console.WriteLine(Add(1,0, true));
            Console.WriteLine(Add(1,2, false));
            Console.WriteLine(Add(1,0, false));
        }
    }
}
