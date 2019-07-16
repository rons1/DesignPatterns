using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientData
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public ClientData(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public override string ToString()
        {
            return $"ClientData is {Name} and ID: {ID}";
        }

    }
}
