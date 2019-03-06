using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPictureManager.Models;

namespace RepositoryPictureManager.Data
{
    public class PictureManagerContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public PictureManagerContext(DbContextOptions options) : base(options) { }

        Microsoft.EntityFrameworkCore.DbSet<COMISION> Comisions { get; set; }
        Microsoft.EntityFrameworkCore.DbSet<PHOTO> Photos { get; set; }
        Microsoft.EntityFrameworkCore.DbSet<SESSION> Sessions { get; set; }
        Microsoft.EntityFrameworkCore.DbSet<SESSION_WORKER> Session_Workers { get; set; }
        Microsoft.EntityFrameworkCore.DbSet<USER> Users { get; set; }
        Microsoft.EntityFrameworkCore.DbSet<WORK> Works { get; set; }
        Microsoft.EntityFrameworkCore.DbSet<WORKER> Workers { get; set; }

        protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SESSION_WORKER>().HasKey(c => new { c.IdSession, c.IdWork });
            modelBuilder.Entity<PHOTO>().HasKey(c => new { c.Id, c.Picture });
        }
    }
}
