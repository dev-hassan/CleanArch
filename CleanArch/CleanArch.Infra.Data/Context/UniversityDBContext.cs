using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
