using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmiCalculatorWebApi.Models
{
    public class UserDbContext:DbContext
    {
        
            public DbSet<UserModel> EmiDetails
        {
                get; set;
            }
            public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
            {

            }

        }


    }

