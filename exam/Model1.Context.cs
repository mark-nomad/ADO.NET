﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exam
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_musicEntities1 : DbContext
    {
        public db_musicEntities1()
            : base("name=db_musicEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }
    }
}