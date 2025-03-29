using System;
class program1
{
    static void Main()
    {
        bool Playagain = true;

        while (Playagain)
        {
            Random random_number = new Random();
            int num = random_number.Next(1, 100);
            int Guess = 0;
            Console.WriteLine("Guess the correct number");

            while (Guess != num)
            {
                Console.WriteLine("Guess Once Again");
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess > num)
                {
                    Console.WriteLine("the number if high");
                }

                if (Guess < num)
                {
                    Console.WriteLine("that is to low");
                }
            }

            Console.WriteLine("yes! YOU WON");

            Console.WriteLine("Do u want to play Again!(Y/N)");
            String respons = Console.ReadLine();
            respons = respons.ToUpper();

            if (respons == "Y")
            {
                Playagain = true;
            }

            else
            {
                Playagain = false;
                Console.WriteLine("thank You for playing");
            }
        }
    }
}