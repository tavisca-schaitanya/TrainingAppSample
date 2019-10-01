using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingApp.Common.Models;
using TrainingAppDAL;
using TrainingAppWebAPI.ResponseModels;

namespace TrainingAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TrainingRepository _repository;

        public LoginController(TrainingRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("Authenticate")]
        public JsonResult Authenticate(User user)
        {
            var loginResponse = new LoginResponse();

            if(_repository.VerifyEmail(user) == false)
            {
                loginResponse.Employee = null;
                loginResponse.ErrorMessage = "Invalid UserName";
                loginResponse.ResponseStatus = "Failed";
            }
            else
            {
                Employee employee = _repository.Authenticate(user);

                if(employee == null)
                {
                    loginResponse.Employee = null;
                    loginResponse.ErrorMessage = "Invalid Password";
                    loginResponse.ResponseStatus = "Failed";
                }
                else
                {
                    loginResponse.Employee = employee;
                    loginResponse.ErrorMessage = "";
                    loginResponse.ResponseStatus = "Passed";
                }
            }
            return new JsonResult(loginResponse);
        }
    }
}
