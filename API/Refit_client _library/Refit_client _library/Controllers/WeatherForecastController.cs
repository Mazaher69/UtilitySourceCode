using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<UserDTO> users = new()
    {
        new UserDTO {
            Id = 1,
            FirstName = "Muhammmad",
            LastName = " Waseem"
        },
        new UserDTO {
            Id = 2,
            FirstName = "Muhammmad",
            LastName = " Ali"
        },
        new UserDTO {
            Id = 3,
            FirstName = "Muhammmad",
            LastName = " Qayum"
        },
        new UserDTO {
            Id = 4,
            FirstName = "Muhammmad",
            LastName = " Hashaam"
        },
    };

        [HttpGet("/api/user/")]
        public List<UserDTO> Get()
        {
            return users;
        }

        [HttpPost("/api/user/")]
        public bool Add(UserDTO user)
        {
            users.Add(user);
            return true;
        }
    }
}