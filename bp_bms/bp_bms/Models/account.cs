//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bp_bms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class account
    {
        public int id { get; set; }
        public string accID { get; set; }
        public string compID { get; set; }
        public string accType { get; set; }
        public string accName { get; set; }
        public decimal amt { get; set; }
        public decimal payment { get; set; }
        public decimal balance { get; set; }
        public System.DateTime date { get; set; }
    }
}
