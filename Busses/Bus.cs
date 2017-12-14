using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    class Bus
    {
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public bool IsLocal { get; set; }
        public List<Line> Lines;

        public Bus(string registrationNumber, string name, bool isLocal)
        {
            RegistrationNumber = registrationNumber;
            Name = name;
            IsLocal = isLocal;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, RegistrationNumber, IsLocal ? "L" : "M");
        }
    }
}
