using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teste_BMaster_Jr.Entities;


// To register or to consult the clients data

namespace Teste_BMaster_Jr.Entities
{
    internal class ClientsData
    {
        public string Name { get; set; }
        public int Document { get; set; }
        public int PIXKey { get; set; }
        public double Balance { get; set; }
        public List<ClientsData> Register { get; set; } = new List<ClientsData>();

        public ClientsData()
        {
        }

        public ClientsData(string name, int document, int pixKey, double balance)
        {
            Name = name;
            Document = document;
            PIXKey = pixKey;
            Balance = balance;
        }

        public void ConsultClient()
        {
            Console.WriteLine("The client register at the moment, are: ");
            Console.WriteLine();
            foreach (ClientsData clientData in Register)
            {
                Console.WriteLine(clientData);
                Console.WriteLine();
            }
        }

        public void NewClient(int quantityClients)
        {
            for (int i = 1; i <= quantityClients; i++)
            {
                Console.WriteLine($"Register the {i}° client");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Document: ");
                int document = int.Parse(Console.ReadLine());

                Console.Write("PIX key: ");
                int pixKey = int.Parse(Console.ReadLine());

                Console.Write("Account Balance: ");
                double balance = double.Parse(Console.ReadLine()); 

                Register.Add(new ClientsData(name, document, pixKey, balance)); 
                Console.WriteLine();
            }
        }

        public void PIXTransfer(int originPIXKey, int destinationPIXKey)
        {
            DataTransfer dataTransfer = new DataTransfer();
            Console.Write($"How much would you like to transfer to the PIX key {destinationPIXKey}: ");
            double value = double.Parse(Console.ReadLine());
            foreach (ClientsData client in Register)
            {
                if (client.PIXKey == originPIXKey)
                {
                    client.Balance = client.Balance - value;
                    Console.WriteLine($"{client.Name} has now a balance of $ {client.Balance}.");
                    Console.WriteLine();
                }
                if (client.PIXKey == destinationPIXKey)
                {
                    client.Balance = client.Balance + value;
                    Console.WriteLine($"And {client.Name} has now a balance of $ {client.Balance}.");
                }
            }
            dataTransfer = new DataTransfer(Name, Document, PIXKey, Balance, originPIXKey, value, destinationPIXKey);
            Console.WriteLine();
            Console.WriteLine(dataTransfer.ToString());
        }

        public override string ToString()
        {
            return "Name: " + Name
                + "\r\nDocument: " + Document
                + "\r\nPIX Key: " + PIXKey
                + "\r\nAccount Balance: " + Balance;
        }
    }
}
