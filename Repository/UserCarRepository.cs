using estudos_crud.Models;

namespace estudos_crud.Repository
{
  public class UserCarRepository : IUserCarRepository
  {



    public Task<UserCar> CreateUserCar(UserCar userCar)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<UserCar>> GetAllCars()
    {
      throw new NotImplementedException();
    }

    public Task<UserCar> SearchPlate(string plate)
    {
      throw new NotImplementedException();
    }
  }
}