using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teste_BMaster_Jr.Entities;


// To register or to know the clients data

namespace Teste_BMaster_Jr.Entities
{
    internal class ClientsData
    {
        public string Name { get; set; }
        public int Document { get; set; }
        public int PIXKey { get; set; }
        public List<ClientsData> Register { get; set; } = new List<ClientsData>();

        public ClientsData()
        {
        }

        public ClientsData(string name, int document, int pixKey)
        {
            Name = name;
            Document = document;
            PIXKey = pixKey;
        }

        public void ConsultClient(ClientsData consult)
        {
            Console.WriteLine("The client register at the moment are: ");
            Console.WriteLine();
            foreach (ClientsData clientData in Register)
            {
                Console.WriteLine(clientData);
                Console.WriteLine();
                //Console.WriteLine(clients2.ConsultClient(clientData));
                //Console.WriteLine(clientData);
            }
            //return null;

            //return Name + "\r\n" + Document + "\r\n" + PIXKey;
            //return Console.WriteLine(ToString());
            //return null;
            /*
            for (int i = 0; i <= consult; i++) 
            {
                //Console.WriteLine(ToString());
                ToString();
                //return Name + Document + PIXKey;
            }
            //return null;  // string like a type of the method
            */
        }

        public void NewClient(int numberClient)
        {
            Console.WriteLine();
            //List<ClientsData> clients = new List<ClientsData>();
            //ClientsData clientsData1 = new ClientsData();

            ClientsData clients2 = new ClientsData();

            for (int i = 1; i <= numberClient; i++)
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
                //clients.Add(clients2);
                Register.Add(clients2);
                //clients.Add(clientsData);
                Console.WriteLine();
            }
            Console.WriteLine();

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
        }


        /*
        
        public void NewClient(ClientsData registerClient)
            {

                Register.Add(registerClient);

            //Console.WriteLine("How many clients would you like to register ? ");
            //Console.WriteLine();
            //int numberClients = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= numberClients; i++)
            //{
            //    Console.WriteLine($"Register the {numberClient + i}° client");
            //    Console.WriteLine();
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Document: ");
            //    int document = int.Parse(Console.ReadLine());
            //    Console.Write("PIX key: ");
            //    int pixKey = int.Parse(Console.ReadLine());
            //    //clientsData = new ClientsData(name, document, pixKey);
            //    Register.Add(new ClientsData(name, document, pixKey));
            //    //clients.Add(clientsData);
            //    Console.WriteLine();
            //}
            //Console.WriteLine(ToString());

            //ClientsData consult = new ClientsData();
            //registryClient.Add(consult);
            //return ToString();
        }

        */
        public override string ToString()
        {
            return "Name: " + Name
                + "\r\nDocument: " + Document
                + "\r\nPIX Key: " + PIXKey;
        }
    }
}
