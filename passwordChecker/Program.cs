using System;


namespace passwordChecker
{
    public class Program
    {
        public static void Main()
        {

            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChar = "~!@#%^&*-+";
            // the below works although I don't think its the correct way...
            string invalidPassword = "password";
            string veryWeak = "1234";

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (Contains(password, uppercase))
            {
                score++;
            }
            if (Contains(password, lowercase))
            {
                score++;
            }
            if (Contains(password, digits))
            {
                score++;
            }
            if (Contains(password, specialChar))
            {
                score++;
            }
            if (Contains(password, invalidPassword))
            {
                score = 0;
            }
            // Is this right?? I am defining what score is which doesn't seem like best practice. But it works.
            if (Contains(password, veryWeak))
            {
                score = 0;
            }

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

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}