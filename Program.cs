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
                        Multiplikation();                        
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

        static void Multiplikation()
        {
            int[] arr = new int[2];
            Console.WriteLine("Skriv in ditt första tal du vill multiplicera: ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ditt andra tal du vill multiplicera: ");
            arr[1] = Convert.ToInt32(Console.ReadLine());

            int resultat = arr[0] * arr[1];
            Console.WriteLine(arr[0] + " * " + arr[1] + " = " + resultat);
            Console.ReadKey();

        }

    }
}