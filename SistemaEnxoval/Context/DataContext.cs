﻿using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Models;
using System.ComponentModel.DataAnnotations;

namespace SistemaEnxoval.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<UserRepository> Users { get; set; }


    }
}