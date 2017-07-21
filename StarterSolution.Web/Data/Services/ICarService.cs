namespace StarterSolution.Web.Services
{
    using StarterSolution.Data.Models;
    using StarterSolution.Web.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICarService
    {
        CarViewModel CreateCar(Car car);
        IEnumerable<CarViewModel> GetCars();
    }
}
