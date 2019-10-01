using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingApp.Common.Models;

namespace TrainingAppWebAPI.ResponseModels
{
    public class LoginResponse
    {
        public Employee Employee;
        public string ErrorMessage;
        public string ResponseStatus;
    }
}
