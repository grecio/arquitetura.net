using System;
using Arch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Arch.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

    }
}
