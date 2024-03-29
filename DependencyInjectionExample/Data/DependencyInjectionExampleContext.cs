﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DependencyInjectionExample.Models;

namespace DependencyInjectionExample.Models
{
    public class DependencyInjectionExampleContext : DbContext
    {
        public DependencyInjectionExampleContext (DbContextOptions<DependencyInjectionExampleContext> options)
            : base(options)
        {
        }

        public DbSet<DependencyInjectionExample.Models.Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book
            {
                id = 1,
                Title = "Book1",
                Genre = "Genre1",
                Price = 20,
                PublishDate = new DateTime(2012, 4, 23)
            }, new Book
            {
                id = 2,
                Title = "Book2",
                Genre = "Genre2",
                Price = 30,
                PublishDate = new DateTime(2008, 6, 13)
            });
        }

        public DbSet<DependencyInjectionExample.Models.User> User { get; set; }
    }
    
}
