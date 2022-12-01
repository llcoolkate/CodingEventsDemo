using Microsoft.EntityFrameworkCore;
using System;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options) 
        {
        }
    }
}
