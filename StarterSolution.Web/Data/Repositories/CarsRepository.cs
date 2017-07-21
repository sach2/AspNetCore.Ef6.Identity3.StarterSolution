using StarterSolution.Data.Models;
using StarterSolution.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterSolution.Data
{
    public class CarsRepository : EntityFrameworkRepository<Car>, ICarsRepository
    {
        public ApplicationDbContext CarsContext
        {
            get { return Context as ApplicationDbContext;}
        }

        public CarsRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Car> GetTopSellingCars(int count)
        {
            return CarsContext.Cars.Take(10).ToList();
        }
    }
}
