//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrowIndigo.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderDetails()
        {
            this.OrderProductDetails = new HashSet<OrderProductDetails>();
        }
    
        public int Order_Id { get; set; }
        public string Retailer_Id { get; set; }
        public string Retailer_Mobile { get; set; }
        public string Totalprice { get; set; }
        public string Payment_Mode { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> Shipping_Address_Id { get; set; }
        public string Order_Status { get; set; }
        public string SAP_Order_ID { get; set; }
        public string GeoCoordinates { get; set; }
        public string Rzp_Order_Id { get; set; }
        public string Rzp_Payment_Id { get; set; }
        public string Rzp_Signature { get; set; }
        public string Rzp_Payment_Status { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProductDetails> OrderProductDetails { get; set; }
    }
}
