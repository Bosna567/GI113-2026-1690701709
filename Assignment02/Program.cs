/*
Student ID :1690700313
Name       :Aditap Suksamran
Section    :129B
No.        :29
Course     :GI113 Computer Programming (GI)
*/
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string Name = "DIMOND";
            const double smeltRate = 0.7500;
            const double SalvageRate = 0.8500;
            const double MaxBatch = 999.00;
            var inGot = 0.0;
            var ore = 0.0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("||                                  ||");
            Console.WriteLine("||              Wellcome            ||");
            Console.WriteLine("||  The Celestial Forge of Eternal  ||");
            Console.WriteLine("||                                  ||");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"{Name} ore Smelting 0.75 / Salvage 0.85 ");
            Console.WriteLine("Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("Key 'B' for Breakdown (Ingot -> Ore)");
            Console.Write("Choice : ");
            bool isSelectnes = char.TryParse(Console.ReadLine(), out char choice);

            if (!isSelectnes || (choice != 'S' && choice != 'B' && choice != 's' && choice != 'b'))
            {
                Console.WriteLine("Chould pick S or B please");
            }
            else if (choice == 'S' || choice == 's')
            {
                Console.Write("Chould pick number (1-999): ");
                bool isInput = double.TryParse(Console.ReadLine(), out ore);
                if (!isInput)
                {
                    Console.WriteLine("Chould pick number (1-999): ");
                }
                else if (ore <= 999 && ore > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    inGot = ore * smeltRate;
                    Console.WriteLine($"{Name} {inGot:f2} ingot = {Name} {ore:f2} ore");
                }
                else
                {
                    Console.WriteLine("Chould pick number (1-999).");
                }
            }
            else if (choice == 'B' || choice == 'b')
            {
                Console.Write("How much you have Dimond (1-999): ");
                bool isInput = double.TryParse(Console.ReadLine(), out ore);
                if (!isInput)
                {
                    Console.WriteLine("Chould pick number (1-999): ");
                }
                else if (ore <= 999 && ore > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    inGot = ore / SalvageRate;
                    Console.WriteLine($"{Name} {ore:f2} ore = {Name} {inGot:f2} ingot");
                }
                else
                {
                    Console.WriteLine("Chould pick number (1-999).");
                }
            }
            else
                
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" pick again : s,S,b,B");
            }
            Console.ResetColor();
        }
    }
}
