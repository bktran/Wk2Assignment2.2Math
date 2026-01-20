namespace Wk2Assignment2._2Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Maths.Add(5,2);
            decimal sum2 = Maths.Add(10.5m, 5.5m, 4.6m);
            float product1 = Maths.Multiply(2f,25f);
            float product2 = Maths.Multiply(4f,5f,6f);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(product1);
            Console.WriteLine(product2);
        }
    }
}
