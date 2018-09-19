using GRPCServer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRPCServer
{
    class EFContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (local)\SQLEXPRESS; Database = Grpc.Server; User ID=sa;Password=cjgame;", options => options.EnableRetryOnFailure());
        }
    }
}
