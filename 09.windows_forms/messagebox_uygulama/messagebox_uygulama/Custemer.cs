using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace messagebox_uygulama
{
    public class Custemer
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }

        public override string ToString()
        {
            return Name + " " + LastName;
        }

    }
}
