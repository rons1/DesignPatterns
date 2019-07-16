using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterWebDataToData : IDBWebData
    {
        PerfectStore ps = new PerfectStore();
        
        public void Store(WebClientData wcd)
        {
            ClientData cd = new ClientData(wcd.Name, wcd.ID);
            ps.Store(cd);
        }
    }
}
