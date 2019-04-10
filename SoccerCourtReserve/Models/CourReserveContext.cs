using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFCoreCodeFirstSample.Models
{
    public class CourtReserveContext : DbContext
    {
        public CourtReserveContext(DbContextOptions<CourtReserveContext> options)
            : base(options)
        { }
        public DbSet<Court> Court { get; set; }
        public DbSet<Reserve> Reserve { get; set; }
        public DbSet <Person> Person { get; set; }
    }
    public class Court
    {
        public int CourtId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }

    public class Reserve
    {
        public int ReserveId { get; set; }
        public DateTime ReserveStart { get; set; }
        public DateTime ReserveEnd { get; set; }
        public Court Courts  { get; set; }
        public Person Person { get; set; }
    }
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }
    }
}