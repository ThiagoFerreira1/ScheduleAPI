﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Schedule.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<User> users { get; set; }
    }
}