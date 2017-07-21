namespace StarterSolution.Web.Services
{
    using StarterSolution.Data;
    using StarterSolution.Data.Models;
    using StarterSolution.Web.Factories;
    using StarterSolution.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CarService : ICarService
    {
        private ICarsRepository _carsRepository;

        public CarService(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository ?? throw new ArgumentNullException(nameof(carsRepository));
        }

        public CarViewModel CreateCar(Car car)
        {
            var createdCar = _carsRepository.Add(car);
            return CarModelFactory.CreateCarViewModel(createdCar);
        }

        public IEnumerable<CarViewModel> GetCars()
        {
            var cars = _carsRepository.GetAll();
            return CarModelFactory.CreateCarViewModels(cars);
        }
    }
}
