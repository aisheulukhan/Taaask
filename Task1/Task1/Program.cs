using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ay;
            Console.WriteLine("Ay yazin");
            Ay = Console.ReadLine();
            switch(Ay)
            {
                case "Yanvar": case "Mart": case "May": case "Iyul": case "Avqust": case "Oktyabr": case "Dekabr":
                    Console.WriteLine(31);
                   break;
                case "Fevral":
                    Console.WriteLine(28);
                    break;
                case "Aprel": case "Iyun": case "Sentyabr": case "Noyabr":
                    Console.WriteLine(30);
                    break;
                default:
                    Console.WriteLine("Bele gun yoxdur");
                    break;


                    //case "Yanvar":
                    //    Console.WriteLine(31);
                    //    break;
                    //case "Fevral":
                    //    Console.WriteLine(28);
                    //    break;
                    //case "Mart":
                    //    Console.WriteLine(31);
                    //    break;
                    //case "Aprel":
                    //    Console.WriteLine(30);
                    //    break;
                    //case "May":
                    //    Console.WriteLine(31);
                    //    break;
                    //case "Iyun":
                    //    Console.WriteLine(30);
                    //    break;
                    //case "Iyul":
                    //    Console.WriteLine(31);
                    //    break;
                    //case "Avqust":
                    //    Console.WriteLine(31);
                    //    break;
                    //case "Sentyabr":
                    //    Console.WriteLine(30);
                    //    break;
                    //case "Oktyabr":
                    //    Console.WriteLine(31);
                    //    break;
                    //case "Noyabr":
                    //    Console.WriteLine(30);
                    //    break;
                    //case "Dekabr":
                    //    Console.WriteLine(31);
                    //    break;
            }


        }
    }
}
