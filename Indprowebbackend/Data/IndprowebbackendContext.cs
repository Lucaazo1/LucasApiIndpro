using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Indprowebbackend.DataModels;

namespace Indprowebbackend.Data
{
    public class IndprowebbackendContext : DbContext
    {
        public IndprowebbackendContext (DbContextOptions<IndprowebbackendContext> options)
            : base(options)
        {
        }
        public DbSet<Indprowebbackend.DataModels.NewsPosts> NewsPosts { get; set; } = default!;
        public DbSet<Indprowebbackend.DataModels.FullContent> FullContent { get; set; } = default!;

    }
}
