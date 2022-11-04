using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_BMaster_Jr.Entities;


namespace Teste_BMaster_Jr.Entities
{
    internal class DataTransfer : ClientsData
    {
        public int OriginPIXKey { get; set; }
        public double Value { get; set; }
        public int DestinationPIXKey { get; set; }

        public DataTransfer()
        {
        }

        public DataTransfer(string name, int document, int pixKey, double balance, int originPIXKey, double value, int destinationPIXKey) : base(name, document, pixKey, balance)
        {
            OriginPIXKey = originPIXKey;
            Value = value;
            DestinationPIXKey = destinationPIXKey;
        }

        //public void PIXTransfer(int originPIXKey, int destinationPIXKey)
        //////public void PIXTransfer()
        //{
        //    DataTransfer dataTransfer = new DataTransfer();
        //    foreach (ClientsData client in Register)
        //    {
        //        //Console.WriteLine(client);
        //        //Console.WriteLine(ToString());
        //        //Console.WriteLine("Now down");
        //        //Console.WriteLine();
        //        //client.ToString();
        //        if (client.PIXKey == originPIXKey)
        //        {
        //            Console.Write($"This client has a balance of $ {client.Balance}. How much would you like to transfer: ");
        //            double value = double.Parse(Console.ReadLine());
        //            dataTransfer = new DataTransfer(Name, Document, PIXKey, Balance, originPIXKey, value, destinationPIXKey);
        //            Console.WriteLine(ToString());
        //        }
        //    }
        //    //    //Console.WriteLine(ToString());
        //    //    //return Value;

        //}

        public override string ToString()
        {
            return "Transfer completed!!\r\nOrigin PIX key: " + OriginPIXKey + "\r\nValue of the transfer: $ "
                + Value + "\r\nDestination PIX key: " + DestinationPIXKey;
        }
    }
}
