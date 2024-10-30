using Microsoft.AspNetCore.Mvc;
using RentCarClient.Models.Input;
using RentCarClient.Service;

namespace RentCarClient.Controllers
{
    public class RentalController : Controller
    {
        private readonly IRental _rentalApi;

        public RentalController(IRental rentalApi)
        {
            _rentalApi = rentalApi;
        }        
        
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreateRental([FromBody] CreateRentalInput request)
        {
            var result = await _rentalApi.CreateRental(request);
            return Json(result);
        }
    }
}
