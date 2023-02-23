namespace estudos_crud.Dtos
{
  public class UserCarDtoDetails
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Plate { get; set; }
    public string? Color { get; set; }
    public string? Cpf { get; set; }
    public int Payment { get; set; }
    public DateTime RegisterCar { get; set; }
  }
}