using System;

namespace MaskingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var newString = "";

            Console.WriteLine("Please tell me a secret");
            var secret = Console.ReadLine();

            for (int i = 0; i < secret.Length - 4; i++)
            {
                newString += "X";
            }

            newString += secret.Substring(secret.Length - 4);

            Console.WriteLine(newString);

            Console.ReadKey();
        }
    }
}
