using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dmusic.Controllers;

namespace Dmusic.Data
{
    public class DmusicContext : DbContext
    {
        public DmusicContext (DbContextOptions<DmusicContext> options)
            : base(options)
        {
        }

        public DbSet<Dmusic.Controllers.Album> Album { get; set; } = default!;
    }
}
