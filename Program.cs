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
    }
}