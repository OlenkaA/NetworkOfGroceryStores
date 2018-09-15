//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Reserve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reserve()
        {
            this.Cheque = new HashSet<Cheque>();
            this.Orders = new HashSet<Orders>();
        }
    
        public int ID_reserve { get; set; }
        public int ID_store { get; set; }
        public int ID_product { get; set; }
        public Nullable<int> ID_sal_res_inv { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public string BarCode { get; set; }
        public Nullable<double> ProductSize { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cheque> Cheque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Products Products { get; set; }
        public virtual Sales_Reserve_Invoice Sales_Reserve_Invoice { get; set; }
        public virtual Store Store { get; set; }
    }
}
