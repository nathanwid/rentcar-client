using Microsoft.AspNetCore.Mvc;
using RentCarClient.Models.Input;
using RentCarClient.Models.Output;
using RentCarClient.Service;

namespace RentCarClient.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _customerApi;

        public CustomerController(ICustomer customerApi)
        {
            _customerApi = customerApi;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> LoginCustomer([FromBody] LoginCustomerInput request)
        {
            var result = await _customerApi.LoginCustomer(request);
            return Json(result);
        }

        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerInput request)
        {
            var result = await _customerApi.CreateCustomer(request);
            return Json(result);
        }
    }
}
