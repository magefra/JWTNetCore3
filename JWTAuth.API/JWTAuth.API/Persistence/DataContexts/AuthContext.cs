using JWTAuth.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuth.API.Persistence.DataContexts
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }


        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
