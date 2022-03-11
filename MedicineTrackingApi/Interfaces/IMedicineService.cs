using MedicineTrackingApi.Models;
using MedicineTrackingApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Interfaces
{
    interface IMedicineService
    {
        Task<Medicines> AddMedicine(CreateMedicine request);

        Task<Medicines> ViewMedicine(int id);
        Task<IEnumerable<Medicines>> ViewMedicineAll();
        Task<Medicines> Search(int id);
        Task<Medicines> EditMedicine(int id);

    }
}
