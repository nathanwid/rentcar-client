using Microsoft.AspNetCore.Mvc;
using RentCarClient.Service;

namespace RentCarClient.Controllers
{
    public class CarController : Controller
    {
        private readonly ICar _carApi;

        public CarController(ICar carApi)
        {
            _carApi = carApi;
        }

        public async Task<IActionResult> GetCar()
        {
            var result = await _carApi.GetCar();
            return Json(result);
        }
    }
}
