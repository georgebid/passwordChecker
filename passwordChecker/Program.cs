using System;


namespace passwordChecker
{
    class Program
    {
        static void Main(string[] args)
        {


            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChar = "~!@#%^&*-+";

            Console.Write("Enter your password: ");
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
            }
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}

