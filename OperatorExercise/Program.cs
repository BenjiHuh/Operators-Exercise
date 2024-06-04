namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            (double areaTestCase, double radiusTestCase) = AreaOfCircle();
            Console.WriteLine($"The area of the circle with the TestCase radius is {areaTestCase} with given radius {radiusTestCase}");
               
        }

        private static (double, double) AreaOfCircle() 
        {
            Console.WriteLine("Please enter a number as a radius (double or integer value)");
            double radius = double.Parse(Console.ReadLine());
            return (Math.PI * Math.Pow(radius, 2), radius);
        }
    }
}
