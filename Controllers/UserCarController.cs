using AutoMapper;
using estudos_crud.Dtos;
using estudos_crud.Models;
using estudos_crud.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace estudos_crud.Controllers
{
  [ApiController]
  [Route("api/user")]
  public class UserCarController : ControllerBase
  {

    private readonly IUserCarService service;

    private readonly IMapper mapper;

    public UserCarController(IUserCarService service, IMapper mapper)
    {
      this.service = service;
      this.mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserCarDto userCarDto)
    {

      var userMapper = this.mapper.Map<UserCar>(userCarDto);

      var user = await this.service.CreateUserCar(userMapper);

      return Ok(user);
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var users = await this.service.GetAllCars();

      return Ok(users.Select(user => this.mapper.Map<UserCarDto>(user)));
    }


    [HttpGet("/search")]
    public async Task<IActionResult> Get(string plate)
    {

      var user = await this.service.SearchPlate(plate);

      return Ok(user);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {

      var user = await this.service.GetOneUser(id);

      var userMapper = this.mapper.Map<UserCarDtoDetails>(user);

      return Ok(userMapper);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(string password)
    {
      var user = await this.service.RemoveUserCar(password);

      var response = JsonSerializer.Serialize(new { user });

      return Ok(response);
    }

  }
}