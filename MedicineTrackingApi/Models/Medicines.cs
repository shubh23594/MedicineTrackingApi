using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Models
{
   /// <summary>
   /// Medicine model
   /// </summary>
    public class Medicines
    {
        [Key]
        public int MedID { get; set; }

        public string FullName { get; set; }

        public string Brand { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string Notes { get; set; }

    }
}
