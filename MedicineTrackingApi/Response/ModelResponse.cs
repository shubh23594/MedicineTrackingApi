using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Response
{
    public class ModelResponse<T> 
    {
        public T Data { get; set; }
    }
}
