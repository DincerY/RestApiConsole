using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public ActionResult<User> GetAllUser()
    {
        User user = new User();
        user.Id = 1;
        user.Name = "Dincer";
        return Ok(user);
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}