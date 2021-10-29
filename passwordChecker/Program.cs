using System;


namespace passwordChecker
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            PasswordScorerGuy bill = new PasswordScorerGuy();
            int score = bill.ScorePassword(password);
            
            Console.WriteLine(score);

            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("The password is extremely strong.");
                    break;

                case 3:
                    Console.WriteLine("The password is strong.");
                    break;

                case 2:
                    Console.WriteLine("The password is medium");
                    break;

                case 1:
                    Console.WriteLine("The password is weak");
                    break;

                case 0:
                    Console.WriteLine("The password doesn't meet any requirements.");
                    break;

                default:
                    Console.WriteLine("Hmm, maybe a snake?");
                    break;
            }
        }

    }
}