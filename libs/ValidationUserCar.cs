using estudos_crud.Models;

namespace estudos_crud.libs
{
  public static class ValidationUserCar
  {

    public static void Validation(UserCar userCar)
    {

      if (String.IsNullOrWhiteSpace(userCar.Name)) throw new ArgumentException("Preencha o campo nome");
      if (String.IsNullOrWhiteSpace(userCar.Phone)) throw new ArgumentException("Preencha o campo telefone");
      if (String.IsNullOrWhiteSpace(userCar.Cpf)) throw new ArgumentException("Preencha o campo cpf");
      if (String.IsNullOrWhiteSpace(userCar.Plate)) throw new ArgumentException("Preencha o campo placa");
      if (String.IsNullOrWhiteSpace(userCar.Color)) throw new ArgumentException("Preencha o campo cor");
      if (userCar.Phone.Length != 14) throw new ArgumentException("Preencha o seu telefone corretamente");
      if (userCar.Cpf.Length != 14) throw new ArgumentException("Preencha o seu cpf corretamente");
      if (userCar.Plate.Length != 9) throw new ArgumentException("Preencha a sua placa corretamente");

    }

  }
}