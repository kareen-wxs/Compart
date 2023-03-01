using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }
        public DbSet<Finished_assembly> Finished_assembly { get; set; }

        public DbSet<CPU> CPU { get; set; }

        public DbSet<Matplata> MotherBoard { get; set; }

        public DbSet<BP> BP { get; set; }

        public DbSet<Case> Case { get; set; }

        public DbSet<ColvoMemory> ColvoMemory { get; set; }

        public DbSet<Cooler> Cooler { get; set; }

        public DbSet<CoolingSystem> CoolingSystem { get; set; }

        public DbSet<DVD> DVD { get; set; }
                                                                              
        public DbSet<GPU> VideoCard { get; set; }

        public DbSet<NetworkCard> NetworkCard { get; set; }

        public DbSet<RAM> RAM { get; set; }

        public DbSet<TypeOfMemory> TypeOfMemory { get; set; }

        public DbSet<VoiceCard> VoiceCard { get; set; }
        public object Matplata { get; internal set; }
    }
}
