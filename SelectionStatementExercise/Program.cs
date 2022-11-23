namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Favorite number

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            do

            {

                Console.WriteLine("Try to guess my favorite number");

                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }

                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }

                else
                {
                    Console.WriteLine("Nevermind"); //Correct! exercise statement "nevermind"
                }

            } while (userInput != favNumber);
        }
    }
}
