using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml.Linq;
using Teste_BMaster_Jr.Entities;


/*

# CLIENTES #

Desenvolver uma api onde seja possivel cadastrar e consultar um cliente, 
além de realizar uma transação entre 2 clientes cadastrados válidos:

* Dados Cliente:
- Nome
- Documento
- ChavePix

* Dados Transferencia:
- Chave Pix Origem
- Valor
- Chave Pix Destino

* Endpoints:
- CadastrarCliente
- ConsultarCliente
- TransferirPix

## Entregáveis ##
* Envie apenas o código fonte (sem dados de bin, debug, etc)
* Preferência no github ou no OneDrive (zipado)
* Priorize/Estruturar sua aplicação seguindo as boas práticas de desenvolvimento
* Evite o uso de frameworks ou bibliotecas externas à linguagem

*/


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
            Console.WriteLine("For an interactive system with us, we need to register a minimum 2 clients ");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("How many clients would you like to register ? ");
            int numberClients = int.Parse(Console.ReadLine());
            Console.WriteLine();

            ClientsData clients2 = new ClientsData();
            clients2.NewClient(numberClients);

            Console.Write("Would you like to consult the clients datas ? \r\n(y/n): ");
            char consult = char.Parse(Console.ReadLine());

            if (consult == 'y')
            {
                clients2.ConsultClient(clients2);
            }
            else
            {
                Console.Write("Would you like to register a new client ? \r\n(y/n): ");
                char newClient = char.Parse(Console.ReadLine());
                if (newClient == 'y')
                {
                    Console.Write("How many clients would you like to register ? ");
                    int numberClients2 = int.Parse(Console.ReadLine());
                    clients2.NewClient(numberClients2);
                }
            }

            /*

            List<ClientsData> clients = new List<ClientsData>();
            //ClientsData clientsData1 = new ClientsData();


            for (int i = 1; i <= numberClients; i++)
            {
                Console.WriteLine($"Register the {i}° client");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Document: ");
                int document = int.Parse(Console.ReadLine());
                Console.Write("PIX key: ");
                int pixKey = int.Parse(Console.ReadLine());
                //clientsData = new ClientsData(name, document, pixKey);
                clients2 = new ClientsData(name, document, pixKey);
                //clients.Add(new ClientsData(name, document, pixKey));
                clients.Add(clients2);
                clients2.NewClient(clients2);
                //clients.Add(clientsData);
                Console.WriteLine();
            }

            


            Console.Write("Would you like to consult the clients datas ? \r\n(y/n): ");
            char consult = char.Parse(Console.ReadLine());

            if (consult == 'y')
            {
                Console.WriteLine();
                Console.WriteLine("The client register at the moment are: ");
                Console.WriteLine();
                foreach(ClientsData clientData in clients)
                {
                    Console.WriteLine(clientData);
                    Console.WriteLine();
                    //Console.WriteLine(clients2.ConsultClient(clientData));
                    //Console.WriteLine(clientData);
                }
            }
            else
            {
                Console.Write("Would you like to register a new client ? \r\n(y/n): ");
                char newClient = char.Parse(Console.ReadLine());
                if (newClient == 'y')
                {
                    Console.Write("How many clients would you like to register ? ");
                    int numberClients2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= numberClients2; i++)
                    {
                        Console.WriteLine($"Register the {numberClients + i}° client");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Document: ");
                        int document = int.Parse(Console.ReadLine());
                        Console.Write("PIX key: ");
                        int pixKey = int.Parse(Console.ReadLine());
                        //clientsData = new ClientsData(name, document, pixKey);
                        clients2 = new ClientsData(name, document, pixKey);
                        //clients.Add(new ClientsData(name, document, pixKey));
                        clients.Add(clients2);
                        clients2.NewClient(clients2);
                        //clients.Add(clientsData);
                        Console.WriteLine();
                    }
                }
            */

            /*

            Console.Write("Would you like to consult the clients datas ? \r\n(y/n): ");
            char consult = char.Parse(Console.ReadLine());

            if (consult == 'y')
            {
                clients2.ConsultClient(clients2);

                //Console.WriteLine();
                //Console.WriteLine("The client register at the moment are: ");
                //Console.WriteLine();
                //foreach (ClientsData clientData in clients)
                //{
                //    Console.WriteLine(clientData);
                //    Console.WriteLine();
                //    //Console.WriteLine(clients2.ConsultClient(clientData));
                //    //Console.WriteLine(clientData);
                //}
            }
            else
            {
                Console.Write("Would you like to register a new client ? \r\n(y/n): ");
                char newClient = char.Parse(Console.ReadLine());
                if (newClient == 'y')
                {
                    Console.Write("How many clients would you like to register ? ");
                    int numberClients2 = int.Parse(Console.ReadLine());
                    clients2.NewClient(numberClients2);
                }
            }

            */


            //Console.WriteLine("Let's do a transfer between each outher");
            //Console.WriteLine();
            //Console.WriteLine("Which client do you choose for first ?");
            //Console.WriteLine();
            //Console.WriteLine("They are:");
            //clients2.ConsultClient(clients2);
            //Console.WriteLine("Press..... to.....choose the first");
            //Console.WriteLine();
            //Console.WriteLine("This have in your account a balance of R$ xxxx");
            //Console.WriteLine();
            //Console.WriteLine("Then, choose the second one:");
            //Console.WriteLine("They are:");
            //clients2.ConsultClient(clients2);
            //Console.WriteLine("Press.....to.....choose the first");
            //Console.WriteLine();
            //Console.WriteLine("This have in the account a balance of R$ xxxx");
            //Console.WriteLine("Who of both will be transfer to each other ?");
            //Console.WriteLine();
            //Console.WriteLine("Press..... to.....");
            //Console.WriteLine();
            //Console.WriteLine("What is the value would you like to transfer ?");
            //Console.WriteLine("Press..... to.....");


            /*

            //ClientsData client = new ClientsData();

            Console.WriteLine($"You've register {clients.Count} clients for all.");

            Console.Write("Would you like to register a new client ? \r\n(y/n): ");
            char newClient = char.Parse(Console.ReadLine());

            if (newClient == 'y')
            {
                ClientsData client = new ClientsData();
                client.NewClient(clients.Count);
                //client = clients.Count;
            }
            Console.Write("Would like to consult the clients datas ? \r\n(y/n): ");
            char consult = char.Parse(Console.ReadLine());
            
            if (consult == 'y')
            {
                Console.WriteLine(client.ConsultClient(clients));
            }

            else if (consult == 'n')
            {
                Console.WriteLine("You have prefered do not consult the clients.");
                Console.Write("So, would you like to register a new client ? \r\nPress 'y' for yes or 'n' for get out of the system: ");
                char registerOrBreak = char.Parse(Console.ReadLine());
                if (registerOrBreak == 'y')
                {
                    Console.WriteLine(client.NewClient(clients));
                }
                else
                {
                    Console.WriteLine("You have prefered get out of the system");
                }
            }

            Console.WriteLine($"You've register {clients.Count} clients with the datas:");

            Console.WriteLine();
            Console.WriteLine("This is the previews");

            foreach (ClientsData clientsData in clients)
            {
                Console.WriteLine(clientsData);
                Console.WriteLine();
            }

            //for (int i = 0; i < clients.Count; i++)
            //{
            //    ClientsData client = clients[i];
            //}

            */

        }
    }
}
