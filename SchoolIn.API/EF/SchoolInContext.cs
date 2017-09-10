﻿using System;
using Microsoft.EntityFrameworkCore;

namespace SchoolIn.API.EF
{
    public class SchoolInContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SchoolInContext(DbContextOptions<SchoolInContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./SchoolIn.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(m => m.ID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
