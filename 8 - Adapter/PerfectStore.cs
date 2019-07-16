using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PerfectStore : IDBData
    {
        public void Store(ClientData cd)
        {
            Console.WriteLine("Data is stored with PerfectStore. Client Data: " + cd.ToString());
        }
    }
}
