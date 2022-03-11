using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Requests
{
    public class CreateMedicine
    {
        public int MedID { get; set; }

        public string FullName { get; set; }

        public string Brand { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Notes { get; set; }
    }
}
