using EmiCalculatorWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmiCalculatorWebApi.Repository
{
    public class UserOrmRepositories : IuserRepositories
    {


         UserDbContext context;

            public UserOrmRepositories(UserDbContext _context)
            {
                context = _context;
            }


            public IEnumerable<UserModel> Getalldetails()
        {
            return context.EmiDetails;
        }
        public bool AddData(UserModel data)
        {
            int rowsaffected = 0;
            context.EmiDetails.Add(data);
            rowsaffected = context.SaveChanges();
             return rowsaffected > 0 ? true : false;
        }
    }
}
