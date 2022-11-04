using System;
using Teste_BMaster_Jr.Entities;
using Teste_BMaster_Jr.Entities.Exceptions;

namespace Teste_BMaster_Jr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Master Bank!");
            Console.WriteLine();
            Console.WriteLine("Let's register some clients to start the system.");
            Console.WriteLine();
            Console.WriteLine("For an interactive system of transfer, we need to register a minimum 2 clients.");
            Console.WriteLine();

            ClientsData clients2 = new ClientsData();
            int count = 0;
            try
            {
                while (true)
                {
                    if (count == 0)
                    {
                        Console.Write("How many clients would you like to register ? ");
                        int quantityClients = int.Parse(Console.ReadLine());
                        clients2.NewClient(quantityClients);
                        Console.WriteLine();
                        count++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do now ?");
                    Console.Write("Press 'r', to register more clients\r\n" +
                        "Or press 'c', to consult the clients\r\nOr press 't' to make a money transfer\r\nOr press 'q' to quit of the system: ");
                    char regiTransQuit = char.Parse(Console.ReadLine());
                    if (regiTransQuit == 'r')
                    {
                        Console.Write("How many clients would you like to register ? ");
                        int numberClients = int.Parse(Console.ReadLine());
                        clients2.NewClient(numberClients);
                    }
                    else if (regiTransQuit == 'c')
                    {
                        clients2.ConsultClient();
                    }
                    else if (regiTransQuit == 't')
                    {
                        Console.Write("Enter with the PIX key of the client are going to make the transfer: ");
                        int originPIXKey = int.Parse(Console.ReadLine());
                        Console.Write("Enter with the PIX key of the client who are going to receive the transfer: ");
                        int destinationPIXKey = int.Parse(Console.ReadLine());
                        clients2.PIXTransfer(originPIXKey, destinationPIXKey);
                    }
                    else if (regiTransQuit == 'q')
                    {
                        Console.WriteLine("You wish to quit of the system");
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("This is a message error: " + e.Message);
                Console.WriteLine("You have entered with the incorrect option.");
                Console.WriteLine("The system will be closed.");
            }
        }
    }
}
