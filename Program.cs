namespace Ovning_sut_23_230928
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meny();
        }
        static void Meny()
        {
            bool program = true;

            while (program)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till kalkylatorn");
                Console.WriteLine("[1] Addition");
                Console.WriteLine("[2] Subtraktion");
                Console.WriteLine("[3] Multiplikation");
                Console.WriteLine("[4] Division");
                Console.WriteLine("[5] Avsluta programmet");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Programmet avslutas. . .");
                        program = false;
                        break;
                }
            }
        }

        static int Multiplikation()
        {
            Console.Write("Skriv in ditt första tal du vill multiplicera: ");

        }

    }
}