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
    
    public partial class Mandi_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mandi_Roles()
        {
            this.Mandi_UserRoles = new HashSet<Mandi_UserRoles>();
        }
    
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mandi_UserRoles> Mandi_UserRoles { get; set; }
    }
}