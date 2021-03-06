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
    
    public partial class Mandi_UserInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mandi_UserInfo()
        {
            this.Mandi_UserRoles = new HashSet<Mandi_UserRoles>();
            this.UsersAddress = new HashSet<UsersAddress>();
            this.UsersBankAccountDetails = new HashSet<UsersBankAccountDetails>();
        }
    
        public string FullName { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Taluka { get; set; }
        public string Pincode { get; set; }
        public string UserType { get; set; }
        public string AdharId { get; set; }
        public string MobileNumber { get; set; }
        public string ProfilePictureUrl { get; set; }
        public Nullable<bool> IsProfileUpdated { get; set; }
        public string DeviceToken { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mandi_UserRoles> Mandi_UserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAddress> UsersAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersBankAccountDetails> UsersBankAccountDetails { get; set; }
    }
}
