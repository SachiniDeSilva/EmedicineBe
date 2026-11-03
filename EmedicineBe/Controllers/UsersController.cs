using EmedicineBe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace EmedicineBe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Registration")]
        public Response register(Users.users)
            {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());


            return response;

        }
}
