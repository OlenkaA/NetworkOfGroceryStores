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
    
    public partial class InvoiceForGoods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InvoiceForGoods()
        {
            this.Invoice_Products = new HashSet<Invoice_Products>();
            this.SalesInvoice = new HashSet<SalesInvoice>();
        }
    
        public int ID_invoice { get; set; }
        public int ID_provisor { get; set; }
        public int ID_workers { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Products> Invoice_Products { get; set; }
        public virtual Provisor Provisor { get; set; }
        public virtual Workers Workers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesInvoice> SalesInvoice { get; set; }
    }
}
