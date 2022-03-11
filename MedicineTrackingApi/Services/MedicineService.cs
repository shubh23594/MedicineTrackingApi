using MedicineTrackingApi.Interfaces;
using MedicineTrackingApi.Models;
using MedicineTrackingApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly MedicineContext dbContext;

        public MedicineService(MedicineContext medicineContext)
        {
            dbContext = medicineContext;
        }


        public async Task<Medicines> AddMedicine(CreateMedicine request)
        {
            Medicines medicines = new Medicines();

            medicines.FullName = request.FullName;
            medicines.Brand = request.Brand;
            medicines.Price = request.Price;
            medicines.Quantity = request.Quantity;
            medicines.ExpiryDate = request.ExpiryDate;
            medicines.Notes = request.Notes;



            await dbContext.Medicine.AddAsync(medicines);

            return medicines;
        }

        public async Task<Medicines> EditMedicine(int id)
        {
            return null;
        }
       

        public Task<Medicines> Search(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Medicines> ViewMedicine(int id)
        {
            var results =  this.dbContext.Medicine
                                     .Where(s => s.MedID == id)
                                     .Select(s => s);

            return (Medicines)results;
        }


        public Task<IEnumerable<Medicines>> ViewMedicineAll()
        {
            throw new NotImplementedException();
        }
    }
}
