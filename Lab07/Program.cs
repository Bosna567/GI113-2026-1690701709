namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");
            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.Write("Choose (1-4): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }
            int power = command switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");
            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");
            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");
            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }
            //part B
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            const int MonsterHp2 = 600;
            Console.Write(" Monster Defense ");
            int.TryParse(Console.ReadLine(), out int monsterDefense2);
            Console.WriteLine($"A Orc King appears! HP {MonsterHp2}, DEF {monsterDefense2}");
            Console.WriteLine("-------------------");
            Console.WriteLine("|   BATTLE MENU    |");
            Console.WriteLine("-------------------");
            Console.WriteLine("1) ====Iron Fists====");
            Console.WriteLine("2) ====Demon Bane====");
            Console.WriteLine("3) ====Signum Crucis====");
            Console.WriteLine("4) ====Holy Light====");
            Console.WriteLine("5) ====Root====");
            Console.WriteLine("6) ====Escape====");
            Console.WriteLine("===================");
            Console.Write("Choose (1-6): ");
            int.TryParse(Console.ReadLine(), out int command2);
            switch (command2)
            {
                case 1:
                    Console.WriteLine("You uses Iron Fists!");
                    break;
                case 2:
                    Console.WriteLine("You casts Demon Bane!");
                    break;
                case 3:
                    Console.WriteLine("Signum Crucis aura engulfs you!");
                    break;
                case 4:
                    Console.WriteLine("You casts Holy Light!");
                    break;
                case 5:
                    Console.WriteLine("You uses Root!");
                    break;
                case 6:
                    Console.WriteLine("You tries to escape!");
                    break;
                default:
                    Console.WriteLine("You hesitates. Invalid command!");
                    break;
            }
            int power2 = command2 switch
            {
                1 => 50,
                2 => 100,
                3 => 250,
                4 => 300,
                5 => 0,
                _ => 0
            };
            int damage2 = Math.Max(0, power2 - monsterDefense2);
            Console.WriteLine($"Damage: {damage2}");
            string rating2 = damage2 switch
            {
                >= 300 => "Critical hit!",
                >= 100 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.Write("Do you want to escape? (yes/no): ");
            string answer2 = Console.ReadLine();
            switch (answer2)
            {
                case "y":
                case "Y":
                case "yes":
                case "Yes":
                    Console.WriteLine("You want to escape!!!");
                    break;
                case "n":
                case "N":
                case "no":
                case "No":
                    Console.WriteLine("You ready to fight.");
                    break;
                default:
                    Console.WriteLine("Please type yes or no.");
                    break;
            }
        }
    }
}
