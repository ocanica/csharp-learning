using Microsoft.EntityFrameworkCore;
using SimpleUser_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleUser_WebApi.Data
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
            : base(options)
        {
        }
    }
}
