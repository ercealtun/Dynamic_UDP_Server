using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDP_Receiver
{
    internal class Parameters
    {   
        public List<string> stringToReceive { get; set; }
        public List<bool> boolToReceive { get; set; }
        public List<int> intToReceive { get; set; }
        public List<float> floatToReceive { get; set; }

        // Constructor
        public Parameters()
        {
            stringToReceive = new List<string>();
            boolToReceive = new List<bool>();
            intToReceive = new List<int>();
            floatToReceive = new List<float>();
        }
    }

}
