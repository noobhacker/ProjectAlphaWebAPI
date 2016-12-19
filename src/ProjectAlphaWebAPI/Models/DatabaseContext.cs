﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectAlphaWebAPI.Models
{
    public class DatabaseContext : DbContext
    {
            public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
            {
            //Database.EnsureCreated();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);

        //    //modelBuilder.Entity<Weather>();
        //}

        public DbSet<Weather> Weathers { get; set; }
  
    }
}
