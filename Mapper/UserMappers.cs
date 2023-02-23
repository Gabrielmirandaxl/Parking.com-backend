using AutoMapper;
using estudos_crud.Dtos;
using estudos_crud.Models;

namespace estudos_crud.Mapper
{
  public class UserMappers : Profile
  {

    public UserMappers()
    {
      CreateMap<UserCarDto, UserCar>();
      CreateMap<UserCar, UserCarDto>();
      CreateMap<UserCar, UserCarDtoDetails>();
    }

  }
}