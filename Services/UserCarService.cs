using estudos_crud.libs;
using estudos_crud.Models;
using estudos_crud.Repository;

namespace estudos_crud.Services
{
  public class UserCarService : IUserCarService
  {

    private readonly IUserCarRepository repository;

    public UserCarService(IUserCarRepository repository)
    {
      this.repository = repository;
    }

    public async Task<UserCar> CreateUserCar(UserCar userCar)
    {

      ValidationUserCar.Validation(userCar);

      var existsPlate = await this.repository.ExistsByPlate(userCar.Plate);
      var existsPhone = await this.repository.ExistsByPhone(userCar.Phone);
      var existsCpf = await this.repository.ExistsByCpf(userCar.Cpf);

      if (existsPlate != null) throw new ArgumentException("Essa placa já é cadastrada!");
      if (existsPhone != null) throw new ArgumentException("Esse número já é cadastrado!");
      if (existsCpf != null) throw new ArgumentException("Esse cpf já é cadastrado");

      var gerador = new Random();

      string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

      string passwordRandom = "";

      for (int c = 0; c < 5; c++)
      {
        int indice = gerador.Next(0, caracteres.Length);
        passwordRandom += caracteres[indice];
      }

      userCar.Password = passwordRandom;
      userCar.RegisterCar = DateTime.Now;

      return await this.repository.CreateUserCar(userCar);
    }

    public async Task<IEnumerable<UserCar>> GetAllCars()
    {
      return await this.repository.GetAllCars();
    }

    public async Task<string> RemoveUserCar(string password)
    {

      var userCar = await this.repository.VerifyPassword(password);

      if (userCar == null) throw new ArgumentException("Não existe um carro cadastrado com essa senha!");




      return await this.repository.RemoveUserCar(userCar);
    }

    public async Task<UserCar> SearchPlate(string plate)
    {
      var searchPlate = await this.repository.SearchPlate(plate);

      if (Math.Round((DateTime.Now - searchPlate.RegisterCar).TotalHours) == 1)
      {
        searchPlate.Payment = 15;
      }
      else if (Math.Round((DateTime.Now - searchPlate.RegisterCar).TotalHours) == 2)
      {
        searchPlate.Payment = 30;
      }
      else if (Math.Round((DateTime.Now - searchPlate.RegisterCar).TotalHours) == 3)
      {
        searchPlate.Payment = 40;
      }
      else if (Math.Round((DateTime.Now - searchPlate.RegisterCar).TotalHours) == 4)
      {
        searchPlate.Payment = 50;
      }
      else if (Math.Round((DateTime.Now - searchPlate.RegisterCar).TotalHours) >= 5)
      {
        searchPlate.Payment = 60;
      }

      if (searchPlate == null) throw new ArgumentException("Nenhum usuário encontrado");

      return searchPlate;
    }

    public async Task<UserCar> GetOneUser(int id)
    {
      var user = await this.repository.GetOneUser(id);


      if (Math.Round((DateTime.Now - user.RegisterCar).TotalHours) == 1)
      {
        user.Payment = 15;
      }
      else if (Math.Round((DateTime.Now - user.RegisterCar).TotalHours) == 2)
      {
        user.Payment = 30;
      }
      else if (Math.Round((DateTime.Now - user.RegisterCar).TotalHours) == 3)
      {
        user.Payment = 40;
      }
      else if (Math.Round((DateTime.Now - user.RegisterCar).TotalHours) == 4)
      {
        user.Payment = 50;
      }
      else if (Math.Round((DateTime.Now - user.RegisterCar).TotalHours) >= 5)
      {
        user.Payment = 60;
      }

      if (user == null) throw new ArgumentException("Nenhum usuário encontrado");

      return await this.repository.GetOneUser(id);
    }

  }
}