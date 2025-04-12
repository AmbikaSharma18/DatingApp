using System;
using Microsoft.EntityFrameworkCore;
using DatingApp.Entities;

namespace DatingApp.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }

}
