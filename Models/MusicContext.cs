﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
            
             
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        
    }
}
