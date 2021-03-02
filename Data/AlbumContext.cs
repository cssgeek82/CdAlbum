using CdAlbum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdAlbum.Data
{
        public class AlbumContext : DbContext
        {
            public AlbumContext(DbContextOptions<AlbumContext> options) : base(options)
            {

            }

            public DbSet<Album> Album { get; set; }
        }
    
}
