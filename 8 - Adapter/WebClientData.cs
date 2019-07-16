using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientData
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string IP { get; set; }
        public bool SSL { get; set; }

        public WebClientData(string name, int id, string ip, bool ssl)
        {
            this.Name = name;
            this.ID = id;
            this.IP = ip;
            this.SSL = ssl;
        }

        public override string ToString()
        {
            return $"WebClientData is {Name} , ID: {ID}, IP: {IP}, and SSL: {SSL}";
        }

    }
}
