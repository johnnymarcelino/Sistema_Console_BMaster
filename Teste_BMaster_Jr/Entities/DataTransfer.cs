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


        public override string ToString()
        {
            return "Transfer completed!!\r\nOrigin PIX key: " + OriginPIXKey + "\r\nValue of the transfer: $ "
                + Value + "\r\nDestination PIX key: " + DestinationPIXKey;
        }
    }
}
