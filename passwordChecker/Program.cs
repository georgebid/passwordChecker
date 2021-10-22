using System;


namespace passwordChecker
{
    public class Program
    {
        public static void Main()
        {
            // declaring the variables, using integers and strings. 
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChar = "~!@#%^&*-+";
            // defining two variables which will cause an invalid password message. 
            string invalidPassword = "password";
            string veryWeak = "1234";

            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            // the users password is rated using a scoring system. All passwords start at 0 and if they meet requirements the score will increase by 1. 
            int score = 0;
            // if the length of the password is greater than or equal to 8 then increase the score by 1.
            if (password.Length >= minLength)
            {
                score++;
            }
            // if the password contains a uppercase letter increase the score by 1.
            if (Contains(password, uppercase))
            {
                score++;
            }
            // if the password contains a lowercase letter increase the score by 1.
            if (Contains(password, lowercase))
            {
                score++;
            // if the password contains a digit increase the score by 1.
            }
            if (Contains(password, digits))
            {
                score++;
            // if the password contains a special character, increase the score by 1.
            }
            if (Contains(password, specialChar))
            {
                score++;
            }
            //  if the password is equal to the invalid password, defined above - the score will be 0.
            if (password.ToLower().Equals(invalidPassword))
            {
                score = 0;
            }
            //  if the password is equal to 1234 (veryWeak), defined above - the score will be 0.
            if (password.Equals(veryWeak))
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
            var charArray = list.ToCharArray();
            return target.IndexOfAny(charArray) != -1;
        }
    }
}