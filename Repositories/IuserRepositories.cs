using EmiCalculatorWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmiCalculatorWebApi.Repository
{
   public interface IuserRepositories
    {
        IEnumerable<UserModel> Getalldetails();
         bool AddData(UserModel data);
    }
}
