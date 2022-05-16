using Microsoft.AspNetCore.Mvc;
using PruebaAPI1.Views;
using System.Linq;

namespace PruebaAPI1.Controllers
{

    //Decoradores que permiten indicar la clase va a ser tratada como controlador API
    [ApiController]

    [Route(template: "api/[controller]")]

    //ControllerBase es la herencia donde no usa vista 
    public class DisneyController : ControllerBase
    {
        private readonly DisneyContext _disney;




        public DisneyController(DisneyContext disney)
        {
            _disney = disney;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_disney.User.ToList());
        }


        [HttpPost]

        public IActionResult Post(UserModel user)
        {
            _disney.User.Add(user);

            _disney.SaveChanges();
            return Ok(_disney.User.ToList());
        }


        [HttpPut]

        public IActionResult Put(UserModel user)
        {
            if (_disney.User.FirstOrDefault(x => x.Id == user.Id) == null) return BadRequest("El usuario no existe");

            var internalUser = _disney.User.Find(user.Id);

            internalUser.UserName = user.UserName;
            internalUser.Password = user.Password;

            _disney.SaveChanges();
            return Ok(_disney.User.ToList());



        }
    }
}
