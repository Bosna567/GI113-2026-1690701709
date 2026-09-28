namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Name = "DIAMOND";
            const double smeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.00;
            var inGot = 0.0;
            var ore = 0.0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--     Welcome to the Forge      --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{Name} ore Smelting 0.25 / Salvage 0.3 ");
            Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");
            Console.Write("Choice : ");
            bool ischoise = char.TryParse(Console.ReadLine(), out char choice);

            if (!ischoise || (choice != 'S' && choice != 'B' && choice != 'S' && choice != 'B'))
            {
                Console.WriteLine("ใส่ของผิด");
            }
            else if (choice == 'S' || choice == 's')
            {
                Console.Write("ต้องการเท่าไหร่ (1-500): ");
                bool isOreInput = double.TryParse(Console.ReadLine(), out ore);
                if (!isOreInput)
                {
                    Console.WriteLine("ใส่1-500(1-500): ");
                }
                else if (ore <= 500 && ore > 0)
                {
                    inGot = ore * smeltRate;
                    Console.WriteLine($"{Name} {inGot:f2} ingot = {Name} {ore:f2} ore");
                }
                else
                {
                    Console.WriteLine("ใส่1-500(1-500).");
                }
            }
            else if (choice == 'B' || choice == 'b')
            {
                Console.Write("ต้องการเท่าไหร่ (1-500): ");
                bool isOreInput = double.TryParse(Console.ReadLine(), out ore);
                if (!isOreInput)
                {
                    Console.WriteLine("ใส่1-500(1-500): ");
                }
                else if (ore <= 500 && ore > 0)
                {
                    inGot = ore / SalvageRate;
                    Console.WriteLine($"{Name} {ore:f2} ore = {Name} {inGot:f2} ingot");
                }
                else
                {
                    Console.WriteLine("ใส่1-500(1-500).");
                }
            }
            else
            {
                Console.WriteLine("ผิด : s,S,b,B");
            }
        }
    }
}
