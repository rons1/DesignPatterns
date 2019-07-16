using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BadStore : IDBWebData
    {
        public void Store(WebClientData wcd)
        {
            Console.WriteLine("Data is stored with BadStore (don't use it). Web Client Data: " + wcd.ToString());
        }
    }
}
