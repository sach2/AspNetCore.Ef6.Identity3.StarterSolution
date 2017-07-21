namespace StarterSolution.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using StarterSolution.Data.Models;
    using StarterSolution.Web.Services;
    using System;
    using System.Threading.Tasks;

    public class CarsController : Controller
    {
        private ICarService _carService { get; set; }

        public CarsController(ICarService carService)
        {
            _carService = carService ?? throw new ArgumentNullException(nameof(carService));
        }

        public IActionResult Index()
        {
            // Create some stub data
            var car = new Car()
            {
                Make = "Test make " + DateTime.Now.Ticks.ToString(),
                Model = "Ford " + DateTime.Now.Ticks.ToString(),
                Year = 1987
            };

            _carService.CreateCar(car);

            return View(_carService.GetCars());
        }
    }
}
