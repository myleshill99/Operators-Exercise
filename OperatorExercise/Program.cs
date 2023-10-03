namespace OperatorExercise
{

    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            int addition = a + b;
            int subtraction = a - b;
            int multipication = a * b;

            Console.WriteLine($"Addition is {addition}");
            Console.WriteLine($"Subtraction is {subtraction}");
            Console.WriteLine($"Multipication is {multipication}");
            Console.WriteLine($"Division is {quotient}");

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");


            // Exercise 2 

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var answer = (Math.PI * Math.Pow(radius, 2));
            Console.WriteLine($"The area of a circle with radius of {radius} is {answer}");
        }
    }
}
