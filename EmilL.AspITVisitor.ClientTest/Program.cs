using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmilL.AspITVisitor.ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Client client = new Client("localhost", 9999))
            {

                //Take input from console and send
                //If input is Exit - stop it
                while (true)
                {
                    Console.WriteLine("Skriv din forespørgsel til serveren. Skriv exit for at stoppe programmet.\n Tast 1, for at få at få aldersspredningen af alle gæster.\n Tast 2, for at få antallet af alle gæster.\n Tast 3, for at få den gennemsnitlige alder af all gæster.");
                    string request = Console.ReadLine();
                    if (request.ToLower() == "exit")
                        break;

                    string response = client.SendAndReceive(request);

                    Console.WriteLine("Svar fra server: " + response);
                }
            }
        }
    }
}
