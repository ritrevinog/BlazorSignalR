using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorSignalR.Shared;

namespace BlazorSignalR.Server.Context
{
    public class BlazorSignalRServerContext : DbContext
    {
        public BlazorSignalRServerContext(DbContextOptions<BlazorSignalRServerContext> options) : base(options) { }

        public DbSet<BlazorSignalR.Shared.Programming> Programming { get; set; }
    }
}
