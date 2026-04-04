using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    internal class NIC
    {
        public string manufacture { get; set; }
        public string mac_address { get; set;}
        public NICType type { get; set;}

        static NIC? obj;
        private NIC()
        {
            
        }
        private NIC(string manufacture, string mac_address, NICType type)
        {
            this.manufacture = manufacture;
            this.mac_address = mac_address;
            this.type = type;
        }

        public static NIC GetInstance(string manufacture, string mac_address, NICType type)
        {
            if (obj == null)
            {
                obj = new NIC(manufacture, mac_address, type);
            }
            return obj;
        }
        public static NIC GetInstance()
        {
            if (obj == null)
            {
                obj = new NIC();
            }
            return obj;
        }
    }
}
