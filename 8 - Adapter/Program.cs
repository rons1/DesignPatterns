using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClientData c = new WebClientData("test", 1, "1.1.1.1", true);
            StoreClient(new AdapterWebDataToData(), c);
            // printed: "Data is stored with PerfectStore. Client Data: ClientData is test and ID: 1"
        }

        public static void StoreClient(IDBWebData d, WebClientData c)
        {
            d.Store(c);
        }
    }
}
