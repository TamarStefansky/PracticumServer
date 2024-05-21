using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkersList.Core.Entities;

namespace WorkersList.Data
{
    

    public class DataContext:DbContext
    {
        

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WorkerList_db");
            optionsBuilder.UseSqlServer(@"Server = 34.122.63.173; Database =TamarStefanskyWorkers; Uid = SqlServer; Pwd = 123456; TrustServerCertificate = Yes");


        }


    }
}
