using MedicineTrackingApi.Interfaces;
using MedicineTrackingApi.Models;
using MedicineTrackingApi.Requests;
using MedicineTrackingApi.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineTrackingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {

        private readonly IMedicineService medicineService;

        MedicineController(IMedicineService medicineService)
        {
            this.medicineService = medicineService;
        }

        [HttpPut("")]
        public async Task<IActionResult> AddMedicine([FromBody] CreateMedicine request)
        {
            try
            {
                var newMedicine = await this.medicineService.AddMedicine(request);

                var response = new ModelResponse<Medicines> { Data = newMedicine };

                return Ok(response);

            }
            catch (Exception ex)
            {

            }
            return null;
        }


        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateMedicine(int id)
        {
            try
            {
                var newMedicine = await this.medicineService.EditMedicine(id);

                var response = new ModelResponse<Medicines> { Data = newMedicine };

                return Ok(response);

            }
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ViewMedicineByID(int id)
        {
            try
            {
                var newMedicine = await this.medicineService.ViewMedicine(id);

                var response = new ModelResponse<Medicines> { Data = newMedicine };

                return Ok(response);

            }
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> ViewMedicineAll()
        {
            try
            {
                var newMedicine = await this.medicineService.ViewMedicineAll();

                var response = new ModelResponse<Medicines> { Data = (Medicines)newMedicine };

                return Ok(response);

            }
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpPost("search/{id}")]
        public async Task<IActionResult> SearchMedicineyID(int id)
        {
            try
            {
                var newMedicine = await this.medicineService.Search(id);

                var response = new ModelResponse<Medicines> { Data = newMedicine };

                return Ok(response);

            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
