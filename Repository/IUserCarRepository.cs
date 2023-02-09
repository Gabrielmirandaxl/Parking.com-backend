
using estudos_crud.Models;

namespace estudos_crud.Repository
{
  public interface IUserCarRepository
  {
    Task<UserCar> CreateUserCar(UserCar userCar);

    Task<IEnumerable<UserCar>> GetAllCars();

    Task<UserCar> SearchPlate(string plate);

  }
}