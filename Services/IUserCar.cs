using estudos_crud.Models;

namespace estudos_crud.Services
{
  public interface IUserCar
  {
    Task<UserCar> CreateUserCar(UserCar userCar);

    Task<IEnumerable<UserCar>> GetAllCars();

    Task<UserCar> SearchPlate(string plate);

  }
}