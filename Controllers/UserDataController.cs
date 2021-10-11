using Microsoft.AspNetCore.Mvc;
using EmiCalculatorWebApi.Models;
using EmiCalculatorWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmiCalculatorWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserDataController:ControllerBase
    {
        private readonly IuserRepositories dblyer = null;

        public UserDataController(IuserRepositories userdetails)
        {
            dblyer =userdetails;

        }

        [HttpGet]

        public IEnumerable<UserModel> GetAllLinks()
        {
            IEnumerable<UserModel> _userdatails = dblyer.Getalldetails();

            return _userdatails;

        }
         [HttpPost]
        public string AddUser([FromBody] UserModel _user)
        {

            Boolean isStatus = dblyer.AddData(_user);
            return GetStatus(isStatus, "Data Creation");
        }
        public string GetStatus(Boolean status, string message)
        {
            if (status)
                return message + " Event detail is successfull";
            else
                return message + " Event detail is Failed";
        }


    }
}