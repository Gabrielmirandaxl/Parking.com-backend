
using estudos_crud.Models;

namespace estudos_crud.Repository
{
  public interface IUserCarRepository
  {
    Task<UserCar> CreateUserCar(UserCar userCar);

    Task<string> RemoveUserCar(UserCar userCar);

    Task<IEnumerable<UserCar>> GetAllCars();

    Task<UserCar> SearchPlate(string plate);

    Task<UserCar> GetOneUser(int id);

    Task<UserCar> VerifyPassword(string password);

    Task<UserCar> ExistsByPlate(string plate);

    Task<UserCar> ExistsByPhone(string phone);

    Task<UserCar> ExistsByCpf(string cpf);

  }
}