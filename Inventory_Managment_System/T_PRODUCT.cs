//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory_Managment_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_PRODUCT()
        {
            this.T_PRODUCT_ORDER = new HashSet<T_PRODUCT_ORDER>();
        }
    
        public int P_ID { get; set; }
        public string P_NAME { get; set; }
        public string P_MEASURE { get; set; }
        public int P_C_ID { get; set; }
        public string P_CURRENCY { get; set; }
        public decimal P_PRICE { get; set; }
        public int P_QUANTITY { get; set; }
        public string P_IMAGE { get; set; }
    
        public virtual T_CATEGORY T_CATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PRODUCT_ORDER> T_PRODUCT_ORDER { get; set; }
    }
}
