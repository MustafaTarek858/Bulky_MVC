﻿using BulyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}
