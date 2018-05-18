using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace LAb_mvc_prvat_nova.Models
{
    public class FriendDB: DbContext
    {
        public DbSet<FriendModel> Friends { get; set; }
     }
}