using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using RousersNet.Models;

namespace RousersNet.DAL
{
    public class PhotoGalleryDBContext : DbContext
    {
        public DbSet<User> userAccount { get; set; }

    }
}