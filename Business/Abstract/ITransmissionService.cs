using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponse Add(AddTransmissionRequest request);
        IList<Transmission> GetList();
        public IList<Transmission> GetTransmissions();
    }
}
