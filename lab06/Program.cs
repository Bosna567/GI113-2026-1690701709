namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;
            //if (lives == 0)
            //{
            //    Console.WriteLine("Game Over");
            //}
            //else
            //{
            //    Console.WriteLine("Continue to play");
            //}


            //Console.WriteLine("Continue to run");
            //bool haskey = true;
            //Console.WriteLine("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);
            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level Input");
            //}

            //else if (level >= 10)
            //{
            //    Console.WriteLine("Boss floor unlocked");
            //}
            //else if (level >= 5)
            //{
            //    if (haskey == true)
            //    {
            //        Console.WriteLine("The door open");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked. Find a Key");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stay shut.");
            //}
            int HeroHp = 100;
            int Fireball = 30;
            int CrimsonSolarFlare = 80;
            int recovery = 40;
            int mana = 100;
            int MonHp = 100;
            int MonAttack = 80;
            int MonSpecialAttack = 50;
            int MonRecovery = 10;
            int MonMana = 100;

            Console.WriteLine("================================");
            Console.WriteLine("||       Vertex Adventure     ||");
            Console.WriteLine("||       Hero Vs Monster      ||");
            Console.WriteLine("================================");
            Console.WriteLine("Action 1: Fireball");
            Console.WriteLine("Action 2: Crimson Solar Flare");
            Console.WriteLine("Action 3: Recovery");

            Console.WriteLine("Choose your action (1 - 3): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int action);

            if (isInputValid == false || action < 1 || action > 3)
            {
                Console.WriteLine("Invalid Input, Please enter 1-3");
            }
            else if (action == 1)
            {
                MonHp -= Fireball;
                mana -= 20;
                Console.WriteLine($"Hero used mana : 20");
                Console.WriteLine($"Hero mana is now {mana}");
                Console.WriteLine($"Hero used Fireball! Monster's HP is now {MonHp}");
            }
            else if (action == 2)
            {
                MonHp -= CrimsonSolarFlare;
                mana -= 50;
                Console.WriteLine($"Hero used mana : 50");
                Console.WriteLine($"Hero mana is now {mana}");
                Console.WriteLine($"Hero used  Crimson Solar Flare! Monster's HP is now {MonHp}");
            }
            else if (action == 3)
            {
                HeroHp += recovery;
                mana -= 40;
                Console.WriteLine($"Hero used mana : 40");
                Console.WriteLine($"Hero mana is now {mana}");
                Console.WriteLine("Hero used recovery!");
                Console.WriteLine("Hero used Recover Energy!");
                Console.WriteLine($"Hero's HP is now {HeroHp}");
            }
            Console.WriteLine("================================");
            Console.WriteLine("           END TURN         ");
            Console.WriteLine("================================");
        }
    }
}
