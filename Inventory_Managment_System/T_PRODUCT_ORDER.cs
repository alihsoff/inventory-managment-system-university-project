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
    
    public partial class T_PRODUCT_ORDER
    {
        public int P_O_ID { get; set; }
        public int P_O_ORDER_ID { get; set; }
        public int P_O_PRODUCT_ID { get; set; }
        public int P_O_QUANTITY { get; set; }
        public decimal P_O_TOTAL_AMOUNT { get; set; }
        public bool P_O_STATUS { get; set; }
    
        public virtual T_ORDER T_ORDER { get; set; }
        public virtual T_PRODUCT T_PRODUCT { get; set; }
    }
}
