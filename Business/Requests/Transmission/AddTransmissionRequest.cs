using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission
{
    public class AddTransmissionRequest
    {
        public string Name { get; set; }

        public AddTransmissionRequest(string name)
        {
            Name = name;
        }
    }
}
