using System;
namespace hej
{
    class program
    {
        static void Main(string[]args)
        {
            Tal();
        }
        static void Tal()
        {
            Console.Write("Tal 1: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv 1 om du vill addera");
            Console.WriteLine("Skriv 2 om du vill subtrahera");
            Console.WriteLine("Skriv 3 om du vill multiplera");
            string valet = Console.ReadLine();
            int addition = x + y;
            int subtraktion = x - y;
            int multi = x * y;
            switch(valet)
            {
                case "1":
                    Console.WriteLine("Dina tal i addition blir " + addition);
                    break;
                case "2":
                    Console.WriteLine("Dina tal i subtraktion blur " + subtraktion);
                    break;
                case "3":
                    Console.WriteLine("Dina tal i multiplikation " + multi);
                    break;
            }
        }
    }
}