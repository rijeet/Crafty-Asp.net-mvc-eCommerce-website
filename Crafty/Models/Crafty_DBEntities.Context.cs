﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crafty.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Crafty_DBEntities1 : DbContext
    {
        public Crafty_DBEntities1()
            : base("name=Crafty_DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart_tbl> Cart_tbl { get; set; }
        public virtual DbSet<Order_tbl> Order_tbl { get; set; }
        public virtual DbSet<Payment_tbl> Payment_tbl { get; set; }
        public virtual DbSet<Product_tbl> Product_tbl { get; set; }
        public virtual DbSet<User_tbl> User_tbl { get; set; }
    }
}
