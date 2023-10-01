//Edris Ahmed (NET23)

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 20);
            int maxAttempts = 5;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            for (int i = 1; i <= maxAttempts; i++)
            {
                Console.Write($"Försök nummer {i}: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else
                {
                    if (guess > randomNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                    else
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }
                    if (i ==  maxAttempts)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                    }
                }
              
            }

        }
    }
}