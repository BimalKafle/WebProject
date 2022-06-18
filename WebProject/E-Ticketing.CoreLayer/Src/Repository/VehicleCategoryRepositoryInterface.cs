using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.Repository
{
    public interface VehicleCategoryRepositoryInterface
    {
        public Task Insert(Vehicle_Category category);
        public Task Update(Vehicle_Category category);
        public Task<Vehicle_Category> GetById(long Id);
        public Task<IEnumerable<Vehicle_Category>> GetAll();
        
    }
}
