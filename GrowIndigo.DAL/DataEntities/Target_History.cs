//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrowIndigo.DAL.DataEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Target_History
    {
        public string Prd_class { get; set; }
        public string Targ_code { get; set; }
        public string prd_year { get; set; }
        public string Prd_season { get; set; }
        public string Prd_code { get; set; }
        public Nullable<System.DateTime> Mod_date { get; set; }
        public string Usr_name { get; set; }
        public decimal Trg_newqty { get; set; }
        public Nullable<double> Trg_oldqty { get; set; }
        public Nullable<float> Trg_newarea { get; set; }
        public Nullable<float> Trg_oldarea { get; set; }
    }
}