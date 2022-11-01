using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_BMaster_Jr.Entities;


// To registry or to know the clients data

namespace Teste_BMaster_Jr.Entities
{
    internal class ClientsData
    {
        public string Name { get; set; }
        public int Document { get; set; }
        public int PIXKey { get; set; }

        public ClientsData()
        {
        }

        public ClientsData(string name, int document, int pixKey)
        {
            Name = name;
            Document = document;
            PIXKey = pixKey;
        }

        public string ConsultClient(List<ClientsData> consult)
        {
            //return Name + "\r\n" + Document + "\r\n" + PIXKey;
            for (int i = 0; i <= consult.Count; i++) 
            {
                Console.WriteLine(ToString());
                //return Name + Document + PIXKey;
            }
            return null;
        }

        public string RegistryClient(List<ClientsData> registryClient)
        {
            Console.WriteLine("How many clients would you like to register ? ");
            Console.WriteLine();
            int numberClients = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberClients; i++)
            {
                Console.WriteLine($"Register the {i}° client");
                Console.WriteLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Document: ");
                int document = int.Parse(Console.ReadLine());
                Console.Write("PIX key: ");
                int pixKey = int.Parse(Console.ReadLine());
                //clientsData = new ClientsData(name, document, pixKey);
                registryClient.Add(new ClientsData(name, document, pixKey));
                //clients.Add(clientsData);
                Console.WriteLine();
            }
            Console.WriteLine(ToString());
            return null;

            //ClientsData consult = new ClientsData();
            //registryClient.Add(consult);
            return ToString();
        }

        public override string ToString()
        {
            return "Name: " + Name 
                + "\r\nDocument: " + Document 
                + "\r\nPIX Key: " + PIXKey;
        }
    }
}
