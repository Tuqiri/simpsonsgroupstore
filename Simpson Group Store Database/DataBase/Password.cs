//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simpson_Group_Store_Database.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Password
    {
        public int Userid { get; set; }
        public string UserPassword { get; set; }
        public string Salt { get; set; }
        public System.DateTime LastLogin { get; set; }
        public System.DateTime LastPasswordChange { get; set; }
    
        public virtual User User { get; set; }
    }
}
