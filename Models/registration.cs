//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nic { get; set; }
        public Nullable<int> cource_id { get; set; }
        public Nullable<int> batch_id { get; set; }
        public Nullable<int> telno { get; set; }
    
        public virtual batch_Details batch_Details { get; set; }
        public virtual cource_Details cource_Details { get; set; }
    }
}
