using System.Security.Cryptography.X509Certificates;

namespace Ovning_sut_23_230928
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public void Addition()
        {
            int[] arr = new int[2];
            arr[0] = Convert.ToInt32(Console.ReadLine());
            arr[1] = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Skriv in det första tal du vill addera:");
            Console.ReadLine();
            Console.WriteLine("Skriv in det andra tal du vill addera:");
            Console.ReadLine();

            Console.WriteLine("{0} adderat med {0} = {0}.", arr[0], arr[1], (arr[0] + arr[1]));

        }
        static void Meny()
        {
            Program Addition = new Program();
            
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
                        Addition.Addition();
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

        //static int Multiplikation()
        //{
        //    Console.Write("Skriv in ditt första tal du vill multiplicera: ");

        //}

    }
}