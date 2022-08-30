namespace LogicProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 for Fibonacci Series");
            Console.WriteLine("2 for Perfect number");
            Console.WriteLine("3 for Prime Number");
            Console.WriteLine("4 for Reverse Number");
            Console.WriteLine("5 for Coupon Number");
            Console.WriteLine("6 for Stop Watch");

            int Prog = Convert.ToInt32(Console.ReadLine());
            switch (Prog)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Series();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Perfect();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime();    
                    break;
                case 4:
                    ReverseANumber reverseANumber = new ReverseANumber();
                    reverseANumber.Reverse();   
                    break;
                case 5:
                    CouponNumber couponNumber = new CouponNumber();
                    couponNumber.Coupon();
                    break;
                default:
                    break;
            }
        }
    }
}