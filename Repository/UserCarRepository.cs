using System.Globalization;
using System;
using estudos_crud.Data;
using estudos_crud.Models;

using Microsoft.EntityFrameworkCore;

namespace estudos_crud.Repository
{
  public class UserCarRepository : IUserCarRepository
  {

    private readonly UserContext? context;

    public UserCarRepository(UserContext context)
    {
      this.context = context;

    }


    public async Task<UserCar> CreateUserCar(UserCar userCar)
    {
      await this.context.AddAsync(userCar);
      await this.context.SaveChangesAsync();
      return userCar;
    }

    public async Task<IEnumerable<UserCar>> GetAllCars()
    {
      return await this.context.Users.ToListAsync();
    }

    public async Task<string> RemoveUserCar(UserCar userCar)
    {

      if (Math.Round((DateTime.Now - userCar.RegisterCar).TotalHours) == 1)
      {
        userCar.Payment = 15;
      }
      else if (Math.Round((DateTime.Now - userCar.RegisterCar).TotalHours) == 2)
      {
        userCar.Payment = 30;
      }
      else if (Math.Round((DateTime.Now - userCar.RegisterCar).TotalHours) == 3)
      {
        userCar.Payment = 40;
      }
      else if (Math.Round((DateTime.Now - userCar.RegisterCar).TotalHours) == 4)
      {
        userCar.Payment = 50;
      }
      else if (Math.Round((DateTime.Now - userCar.RegisterCar).TotalHours) >= 5)
      {
        userCar.Payment = 60;
      }

      this.context.Users.Remove(userCar);
      await this.context.SaveChangesAsync();

      return $"Usuário removido com sucesso. Permaneceu {Math.Round((DateTime.Now - userCar.RegisterCar).TotalHours)} horas no estacionamento. Pagamento: R$ {userCar.Payment}";
    }


    public async Task<UserCar> SearchPlate(string plate)
    {
      return await this.context.Users.Where(x => x.Plate == plate).FirstOrDefaultAsync();
    }

    public async Task<UserCar> GetOneUser(int id)
    {
      return await this.context.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<UserCar> VerifyPassword(string password)
    {
      return await this.context.Users.Where(x => x.Password == password).FirstOrDefaultAsync();
    }

    public async Task<UserCar> ExistsByPlate(string plate)
    {
      return await this.context.Users.Where(x => x.Plate == plate).FirstOrDefaultAsync();
    }

    public async Task<UserCar> ExistsByPhone(string phone)
    {
      return await this.context.Users.Where(x => x.Phone == phone).FirstOrDefaultAsync();
    }


    public async Task<UserCar> ExistsByCpf(string cpf)
    {
      return await this.context.Users.Where(x => x.Cpf == cpf).FirstOrDefaultAsync();
    }

  }
}