﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetworkOfGroceryStores
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_NetworkOfGroceryStoresEntities : DbContext
    {
        public DB_NetworkOfGroceryStoresEntities()
            : base("name=DB_NetworkOfGroceryStoresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cheque> Cheque { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Invoice_Products> Invoice_Products { get; set; }
        public virtual DbSet<InvoiceForGoods> InvoiceForGoods { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Provisor> Provisor { get; set; }
        public virtual DbSet<Reserve> Reserve { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Sales_Reserve_Invoice> Sales_Reserve_Invoice { get; set; }
        public virtual DbSet<SalesInvoice> SalesInvoice { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Subtypes> Subtypes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
    }
}
