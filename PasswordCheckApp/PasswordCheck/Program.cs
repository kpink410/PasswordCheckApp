
namespace PasswordCheck
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your password: ");
            Console.ReadLine();
            Console.WriteLine(CheckPassword("!aB085555555", 12));


            if (false)

            {
                //Console.WriteLine("Error");

            }
            else
            {
                Console.WriteLine("Your password is Valid and Accepted.");
            }
        }
        static bool CheckPassword(string input, int minimum)
        {
            bool hasNumber = false;
            bool hasCapital = false;
            bool hasLowerCase = false;
            bool hasSpecialChar = false;
            int minChar = 7;
            char currentCharacter;

            if (!(input.Length >= minChar))
            {
                return false;

            }
            for (int i = 0; i < input.Length; i++)
            {
                currentCharacter = input[i];
                if (char.IsDigit(currentCharacter))
                {
                    hasNumber = true;
                }
                else if (char.IsUpper(currentCharacter))
                {
                    hasCapital = true;
                }
                else if (char.IsLower(currentCharacter))
                {
                    hasLowerCase = true;
                }
                else if (!char.IsLetterOrDigit(currentCharacter))
                {
                    hasSpecialChar = true;
                }
                if (hasNumber && hasCapital && hasLowerCase && hasSpecialChar)
                {
                    return true;
                }
            }
            return false;
        }
    }
}