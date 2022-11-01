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
        public ClientsData OriginPIXKey { get; set; }
        public double Value { get; set; }
        public ClientsData DestinationPIXKey { get; set; }

        public DataTransfer()
        {
        }

        public DataTransfer(string name, int document, int pixKey, ClientsData originPIXKey, double value, ClientsData destinationPIXKey) : base(name, document, pixKey)
        {
            OriginPIXKey = originPIXKey;
            Value = value;
            DestinationPIXKey = destinationPIXKey;
        }

        public string PIXTransfer(string pixTransfer)
        {
            return pixTransfer;
        }
    }
}
