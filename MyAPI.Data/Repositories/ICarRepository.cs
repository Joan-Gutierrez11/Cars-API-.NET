using MyAPI.Model;
using System.Threading.Tasks;

namespace MyAPI.Data.Repositories
{
    
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCars(); 

        Task<Car> GetDetail(int id);

        Task<bool> InsertCar(Car car);

        Task<bool> UpdateCar(Car car);

        Task<bool> DeleteCar(Car car);
        
    }

}