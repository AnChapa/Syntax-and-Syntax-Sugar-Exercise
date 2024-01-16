namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise1
            Console.WriteLine("What number is less than 9:");
            var response = int.Parse(Console.ReadLine());
            var answer = (response < 9) ? " is less than 9." : " is greater than or equal to 9.";
            Console.WriteLine($"{response}{answer}");
        }
    }
}
